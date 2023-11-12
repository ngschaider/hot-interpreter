using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeIf : NodeExpression
{

    private NodeExpression condition;
    private NodeExpression trueBody;
    private NodeExpression falseBody;

    public NodeIf(NodeExpression condition, NodeExpression trueBody, NodeExpression falseBody)
    {
        this.condition = condition;
        this.trueBody = trueBody;
        this.falseBody = falseBody;
    }
}
