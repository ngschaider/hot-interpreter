using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeBlock : NodeExpression
{

    NodeExpression[] expressions;

    public NodeBlock(NodeExpression[] expressions)
    {
        this.expressions = expressions;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Block:");
        csb.ChangeIndent(1);

        csb.AppendLine("Expressions: ");
        csb.ChangeIndent(1);
        foreach(NodeExpression expression in expressions) {
            expression.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);
    }

}