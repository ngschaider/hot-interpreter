using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeBoolNot : NodeExpression
{

    private NodeExpression expression;

    public NodeBoolNot(NodeExpression expression)
    {
        this.expression = expression;
    }
}
