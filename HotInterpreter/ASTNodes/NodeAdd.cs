using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeAdd : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeAdd(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

}
