using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeEqual : NodeExpression
{

    NodeExpression leftSide;
    NodeExpression rightSide;

    public NodeEqual(NodeExpression leftSide, NodeExpression rightSide) {
        this.leftSide = leftSide;
        this.rightSide = rightSide;
    }

}
