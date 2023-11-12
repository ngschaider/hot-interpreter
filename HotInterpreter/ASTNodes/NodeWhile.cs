using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeWhile : NodeExpression
{

    private NodeExpression condition;
    private NodeExpression body;

    public NodeWhile(NodeExpression condition, NodeExpression body)
    {
        this.condition = condition;
        this.body = body;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - While:");
        csb.ChangeIndent(1);

        csb.AppendLine("Condition: ");
        csb.ChangeIndent(1);
        condition.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        csb.AppendLine("Body: ");
        csb.ChangeIndent(1);
        body.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);
        
        csb.ChangeIndent(-1);
    }


}
