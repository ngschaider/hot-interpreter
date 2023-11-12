using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeSubtract : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeSubtract(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

}