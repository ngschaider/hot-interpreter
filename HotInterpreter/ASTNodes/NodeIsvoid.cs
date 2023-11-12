using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeIsvoid : NodeExpression
{

    NodeExpression expression;

    public NodeIsvoid(NodeExpression expression) {
        this.expression = expression;
    }

}
