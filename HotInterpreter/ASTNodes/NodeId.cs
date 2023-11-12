using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeId : NodeExpression
{

    public string name;

    public NodeId(string name)
    {
        this.name = name;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - ID:");
        csb.ChangeIndent(1);
        csb.AppendLine("Name: " + name);
        csb.ChangeIndent(-1);
    }

}
