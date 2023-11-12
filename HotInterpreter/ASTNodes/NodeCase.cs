using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

public class NodeCase : NodeExpression
{

    private NodeExpression expr0;
    private Tuple<NodeFormal, NodeExpression>[] branches;

    public NodeCase(NodeExpression expr0, Tuple<NodeFormal, NodeExpression>[] branches)
    {
        this.expr0 = expr0;
        this.branches = branches;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Case: ");
        csb.ChangeIndent(1);

        csb.AppendLine("Expression 0: ");
        csb.ChangeIndent(1);
        expr0.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("Branches: ");
        csb.ChangeIndent(1);
        for(int i = 0; i < branches.Length; i++) {
            Tuple<NodeFormal, NodeExpression> branch = branches[i];

            csb.ChangeIndent(1);
            csb.AppendLine("Branch " + i + ": ");

            csb.ChangeIndent(1);
            csb.AppendLine("Formal: ");
            branch.Item1.ToCustomStringBuilder(csb);
            csb.ChangeIndent(-1);

            csb.ChangeIndent(1);
            csb.AppendLine("Expression: ");
            branch.Item2.ToCustomStringBuilder(csb);
            csb.ChangeIndent(-1);

            csb.ChangeIndent(-1);
        }
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }
}
