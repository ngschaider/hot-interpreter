using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeNegative : NodeExpression
{

    private NodeExpression expression;

    public NodeNegative(NodeExpression expression)
    {
        this.expression = expression;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Negative:");
        csb.ChangeIndent(1);

        expression.ToCustomStringBuilder(csb);
        
        csb.ChangeIndent(-1);
    }
}
