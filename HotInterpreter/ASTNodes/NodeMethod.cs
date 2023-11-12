using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeMethod
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
}
