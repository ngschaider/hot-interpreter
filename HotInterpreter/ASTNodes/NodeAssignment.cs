using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeAssignment : NodeExpression
{

    string variable;
    NodeExpression expression;


    public NodeAssignment(string variable, NodeExpression expression) {
        this.variable = variable;
        this.expression = expression;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb) {
        csb.AppendLine("Expression - Assignment: ");
        csb.ChangeIndent(1);

        csb.AppendLine("Variable: " + variable);

        expression.ToCustomStringBuilder(csb);

        csb.ChangeIndent(-1);
    }

}
