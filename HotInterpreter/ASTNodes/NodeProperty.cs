using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeProperty
{

    private NodeFormal formal;
    private NodeExpression expression;

    public NodeProperty(NodeFormal formal, NodeExpression expression)
    {
        this.formal = formal;
        this.expression = expression;
    }
}
