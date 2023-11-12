using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeType : BaseNode
{

    private string name;

    public NodeType(string name)
    {
        this.name = name;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Type:");
        csb.ChangeIndent(1);
        csb.AppendLine("Name: " + name);
        csb.ChangeIndent(-1);
    }

}
