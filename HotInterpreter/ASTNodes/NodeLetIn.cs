using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeLetIn : NodeExpression
{

    NodeProperty[] properties;
    NodeExpression expression;

    public NodeLetIn(NodeProperty[] properties, NodeExpression expression) {
        this.properties = properties;
        this.expression = expression;
    }

}
