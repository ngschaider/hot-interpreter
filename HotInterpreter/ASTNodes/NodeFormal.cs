using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeFormal
{
    private string name;
    private string type;

    public NodeFormal(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Formal: ");
        csb.ChangeIndent(1);

        csb.AppendLine("Name: " + name);
        csb.AppendLine("Type: " + type);

        csb.ChangeIndent(-1);
    }
}
