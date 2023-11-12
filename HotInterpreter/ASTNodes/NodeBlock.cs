using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeBlock : NodeExpression
{

    NodeExpression[] expressions;

    public NodeBlock(NodeExpression[] expressions)
    {
        this.expressions = expressions;
    }


}