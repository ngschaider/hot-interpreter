using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeMultiply : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeMultiply(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Multiply:");
        csb.ChangeIndent(1);

        csb.AppendLine("Left Side: ");
        csb.ChangeIndent(1);
        leftSide.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("Right Side: ");
        csb.ChangeIndent(1);
        rightSide.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);
    }

}
