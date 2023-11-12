using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeClassDefine : BaseNode
{

    private string name;
    private string parent;
    private NodeMethod[] methods;
    private NodeProperty[] properties;

    public NodeClassDefine(string name, string parent, NodeMethod[] methods, NodeProperty[] properties)
    {
        this.name = name;
        this.parent = parent;
        this.methods = methods;
        this.properties = properties;
    }

}
