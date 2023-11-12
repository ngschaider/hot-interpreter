using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeBoolNot : NodeExpression
{

    private NodeExpression expression;

    public NodeBoolNot(NodeExpression expression)
    {
        this.expression = expression;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Bool Not:");
        csb.ChangeIndent(1);

        csb.AppendLine("Expression: ");
        csb.ChangeIndent(1);
        expression.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);
        
        csb.ChangeIndent(-1);
    }
}
