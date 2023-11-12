using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeIf : NodeExpression
{

    private NodeExpression condition;
    private NodeExpression trueBranch;
    private NodeExpression falseBranch;

    public NodeIf(NodeExpression condition, NodeExpression trueBranch, NodeExpression falseBranch)
    {
        this.condition = condition;
        this.trueBranch = trueBranch;
        this.falseBranch = falseBranch;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - If:");
        csb.ChangeIndent(1);

        csb.AppendLine("Condition: ");
        csb.ChangeIndent(1);
        condition.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("True Branch: ");
        csb.ChangeIndent(1);
        trueBranch.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("False Branch: ");
        csb.ChangeIndent(1);
        falseBranch.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }

}
