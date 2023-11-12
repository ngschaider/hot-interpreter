using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeMultiply : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeMultiply(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

}
