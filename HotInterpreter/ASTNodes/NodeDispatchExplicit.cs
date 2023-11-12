using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeDispatchExplicit : NodeExpression
{

    NodeExpression instance;
    NodeType targetClass;
    NodeId methodName;
    NodeExpression[] parameters;

    public NodeDispatchExplicit(NodeExpression instance, NodeType targetClass, NodeId methodName, NodeExpression[] parameters) {
        this.instance = instance;
        this.targetClass = targetClass;
        this.methodName = methodName;
        this.parameters = parameters;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Dispatch Explicit:");
        csb.ChangeIndent(1);

        csb.AppendLine("Target Class: ");
        csb.ChangeIndent(1);
        targetClass.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);
        
        csb.AppendLine("Method Name: ");
        csb.ChangeIndent(1);
        methodName.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("Instance: ");
        csb.ChangeIndent(1);
        instance.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("Parameters: ");
        csb.ChangeIndent(1);
        foreach(NodeExpression parameter in parameters) {
            parameter.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }

}
