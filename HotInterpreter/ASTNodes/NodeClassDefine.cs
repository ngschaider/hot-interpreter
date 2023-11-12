using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeClassDefine : BaseNode
{

    public NodeType name;
    public NodeType? parent;
    private NodeMethod[] methods;
    private NodeProperty[] properties;

    public NodeClassDefine(NodeType name, NodeType? parent, NodeMethod[] methods, NodeProperty[] properties)
    {
        this.name = name;
        this.parent = parent;
        this.methods = methods;
        this.properties = properties;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("ClassDefine: ");
        csb.ChangeIndent(1);

        csb.AppendLine("Name: ");
        csb.ChangeIndent(1);
        name.ToCustomStringBuilder(csb);
        csb.ChangeIndent(-1);

        
        if(parent != null) {
            csb.AppendLine("Parent: ");
            csb.ChangeIndent(1);
            parent.ToCustomStringBuilder(csb);
            csb.ChangeIndent(-1);
        } else {
            csb.AppendLine("Parent: null");
        }
        

        csb.AppendLine("Methods: ");
        csb.ChangeIndent(1);
        foreach (NodeMethod method in methods)
        {
            method.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);

        csb.AppendLine("Properties: ");
        csb.ChangeIndent(1);
        foreach (NodeProperty property in properties)
        {
            property.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);

        csb.ChangeIndent(-1);
    }

}
