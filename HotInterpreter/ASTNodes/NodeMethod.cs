using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeMethod
{

    private string name;
    private NodeFormal[] formals;
    private string returnType;

    public NodeMethod(string name, NodeFormal[] formals, string returnType)
    {
        this.name = name;
        this.formals = formals;
        this.returnType = returnType;
    }

    public void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Method: ");
        csb.ChangeIndent(1);

        csb.AppendLine("Name: " + name);
        csb.AppendLine("Return Type: " + returnType);

        csb.AppendLine("Formals: ");
        csb.ChangeIndent(1);
        foreach (NodeFormal formal in formals)
        {
            formal.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }
}
