using static CoolParser;

internal class ASTBuilder
{

    public NodeProgram VisitProgram(ProgramContext context)
    {
        NodeClassDefine[] classDefines = context.classDefine().Select(c => this.VisitClassDefine(c)).ToArray();
        return new NodeProgram(classDefines);
    }

    private NodeClassDefine VisitClassDefine(ClassDefineContext context)
    {

        string name = context.TYPE()[0].Symbol.Text;
        string parent = context.TYPE()[1].Symbol.Text;
        NodeMethod[] methods = context.feature().Where(feature => feature.method() != null).Select(feature => this.VisitMethod(feature.method())).ToArray();
        NodeProperty[] properties = context.feature().Where(feature => feature.property() != null).Select(feature => this.VisitProperty(feature.property())).ToArray();

        return new NodeClassDefine(name, parent, methods, properties);
    }

    private NodeMethod VisitMethod(MethodContext context)
    {
        string name = context.ID().Symbol.Text;
        NodeFormal[] formals = context.formal().Select(formal => this.VisitFormal(formal)).ToArray();
        string returnType = context.TYPE().Symbol.Text;

        return new NodeMethod(name, formals, returnType);
    }

    private NodeFormal VisitFormal(FormalContext context)
    {
        string name = context.ID().Symbol.Text;
        string type = context.TYPE().Symbol.Text;
        return new NodeFormal(name, type);
    }

    private NodeProperty VisitProperty(PropertyContext context)
    {
        NodeFormal formal = VisitFormal(context.formal());
        NodeExpression expression = VisitExpression(context.expression());
        return new NodeProperty(formal, expression);
    }

    private NodeExpression VisitExpression(ExpressionContext context)
    {
        if (context is DispatchExplicitContext dispatchExplicitContext)
        {
            NodeExpression instance = VisitExpression(dispatchExplicitContext.expression(0));
            string targetClass = dispatchExplicitContext.TYPE().Symbol.Text; // caution: type is optional
            string methodName = dispatchExplicitContext.ID().Symbol.Text;
            NodeExpression[] formals = dispatchExplicitContext.expression().Skip(1).Select(expr => VisitExpression(expr)).ToArray();
            
            return new NodeDispatchExplicit(instance, targetClass, methodName, formals);
        }
        else if (context is DispatchImplicitContext)
        {
            throw new Exception("not implemented");
        }
        else if (context is IfContext ifContext)
        {
            NodeExpression condition = VisitExpression(ifContext.expression()[0]);
            NodeExpression trueBody = VisitExpression(ifContext.expression()[1]);
            NodeExpression falseBody = VisitExpression(ifContext.expression()[2]);
            return new NodeIf(condition, trueBody, falseBody);
        }
        else if (context is WhileContext whileContext)
        {
            NodeExpression condition = VisitExpression(whileContext.expression()[0]);
            NodeExpression body = VisitExpression(whileContext.expression()[1]);
            return new NodeWhile(condition, body);
        }
        else if (context is BlockContext blockContext)
        {
            NodeExpression[] expressions = blockContext.expression().Select(expressionContext => this.VisitExpression(expressionContext)).ToArray();
            return new NodeBlock(expressions);
        }
        else if (context is CaseContext caseContext)
        {
            NodeExpression expr0 = VisitExpression(caseContext.expression()[0]);
            Tuple<NodeFormal, NodeExpression>[] branches = caseContext.formal().Select((formalContext, index) =>
            {
                NodeFormal formal = this.VisitFormal(formalContext);
                NodeExpression expression = VisitExpression(caseContext.expression()[index + 1]);
                return new Tuple<NodeFormal, NodeExpression>(formal, expression);
            }).ToArray();

            return new NodeCase(expr0, branches);
        }
        else if (context is NewContext newContext)
        {
            string type = newContext.TYPE().Symbol.Text;
            return new NodeNew(type);
        }
        else if (context is NegativeContext negativeContext)
        {
            NodeExpression expression = VisitExpression(negativeContext.expression());
            return new NodeNegative(expression);
        }
        else if (context is IsvoidContext isvoidContext)
        {
            NodeExpression expression = VisitExpression(isvoidContext.expression());
            return new NodeIsvoid(expression);
        }
        else if (context is ArithmeticContext arithmeticContext)
        {
            NodeExpression leftSide = VisitExpression(arithmeticContext.expression()[0]);
            NodeExpression rightSide = VisitExpression(arithmeticContext.expression()[1]);
            if (arithmeticContext.op.Text == "-")
            {
                return new NodeSubtract(leftSide, rightSide);
            }
            else if (arithmeticContext.op.Text == "+")
            {
                return new NodeAdd(leftSide, rightSide);
            }
            else if (arithmeticContext.op.Text == "/")
            {
                return new NodeDivide(leftSide, rightSide);
            }
            else if (arithmeticContext.op.Text == "*")
            {
                return new NodeMultiply(leftSide, rightSide);
            }
            else
            {
                throw new Exception("Error while building AST (Arithmetic)");
            }
        }
        else if (context is ComparissonContext comparisonContext)
        {
            NodeExpression leftSide = VisitExpression(comparisonContext.expression()[0]);
            NodeExpression rightSide = VisitExpression(comparisonContext.expression()[1]);

            if (comparisonContext.op.Text == "<")
            {
                return new NodeLessThan(leftSide, rightSide);
            }
            else if (comparisonContext.op.Text == "<=")
            {
                return new NodeLessThanOrEqual(leftSide, rightSide);
            }
            else if (comparisonContext.op.Text == "=")
            {
                return new NodeEqual(leftSide, rightSide);
            }
            else
            {
                throw new Exception("Error while building AST (Comparison)");
            }
        }
        else if (context is BoolNotContext boolNotContext)
        {
            NodeExpression expression = VisitExpression(boolNotContext.expression());
            return new NodeBoolNot(expression);
        }
        else if (context is ParenthesesContext paranthesesContext)
        {
            NodeExpression expression = VisitExpression(paranthesesContext.expression());
            return new NodeParantheses(expression);
        }
        else if (context is IdContext idContext)
        {
            return new NodeId(idContext.ID().Symbol.Text);
        }
        else if (context is IntContext intContext)
        {
            return new NodeIntConstant(int.Parse(intContext.INT().Symbol.Text));
        }
        else if (context is StringContext stringContext)
        {
            return new NodeStringConstant(stringContext.STRING().Symbol.Text);
        }
        else if (context is BooleanContext booleanContext)
        {
            if (booleanContext.value.Type == TRUE)
            {
                return new NodeBoolConstant(true);
            }
            else if (booleanContext.value.Type == FALSE)
            {
                return new NodeBoolConstant(false);
            }
            else
            {
                throw new Exception("Error while building NodeBoolConstant");
            }
        }
        else if(context is LetInContext letInContext) {
            throw new Exception("not implemented");
        }
        else
        {
            throw new Exception("Error while building NodeExpression");
        }
    }
}