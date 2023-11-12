using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeNegative : NodeExpression
{

    private NodeExpression expression;

    public NodeNegative(NodeExpression expression)
    {
        this.expression = expression;
    }
}
