using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeLessThanOrEqual : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeLessThanOrEqual(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

}
