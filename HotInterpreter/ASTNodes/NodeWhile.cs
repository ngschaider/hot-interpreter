using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeWhile : NodeExpression
{

    private NodeExpression condition;
    private NodeExpression body;

    public NodeWhile(NodeExpression condition, NodeExpression body)
    {
        this.condition = condition;
        this.body = body;
    }


}
