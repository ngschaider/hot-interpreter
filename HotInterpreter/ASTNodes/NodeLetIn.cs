using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeLetIn : NodeExpression
{

    NodeProperty[] properties;
    NodeExpression expression;

    public NodeLetIn(NodeProperty[] properties, NodeExpression expression) {
        this.properties = properties;
        this.expression = expression;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Let In:");
        csb.ChangeIndent(1);

        csb.AppendLine("Properties: ");
        csb.ChangeIndent(1);
        foreach(NodeProperty property in properties) {
            property.ToCustomStringBuilder(csb);
        }
        csb.ChangeIndent(-1);
        
        csb.ChangeIndent(-1);
    }

}
