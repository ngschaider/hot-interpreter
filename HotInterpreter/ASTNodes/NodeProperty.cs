using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeProperty
{

    private NodeFormal formal;
    private NodeExpression? expression;

    public NodeProperty(NodeFormal formal, NodeExpression? expression)
    {
        this.formal = formal;
        this.expression = expression;
    }

    public void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Property: ");
        csb.ChangeIndent(1);

        formal.ToCustomStringBuilder(csb);

        if(expression != null) {
            expression.ToCustomStringBuilder(csb);
        } else {
            csb.AppendLine("Expression: null");
        }
        

        csb.ChangeIndent(-1);
    }
}
