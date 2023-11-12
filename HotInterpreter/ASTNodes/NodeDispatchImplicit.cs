using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeDispatchImplicit : NodeExpression
{

    string methodName;
    NodeExpression[] parameters;

    public NodeDispatchImplicit(string methodName, NodeExpression[] parameters) {
        this.methodName = methodName;
        this.parameters = parameters;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Dispatch Implicit:");
        csb.ChangeIndent(1);

        csb.AppendLine("Method Name: " + methodName);

        csb.AppendLine("Parameters: ");
        csb.ChangeIndent(1);
        foreach(NodeExpression parameter in parameters) {
            parameter.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }

}
