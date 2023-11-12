using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeNew : NodeExpression
{

    private string type;

    public NodeNew(string type)
    {
        this.type = type;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - New:");
        csb.ChangeIndent(1);
        csb.AppendLine("Type: " + type);
        csb.ChangeIndent(-1);
    }
}
