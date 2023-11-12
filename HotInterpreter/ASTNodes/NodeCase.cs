using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeCase : NodeExpression
{

    private NodeExpression expr0;
    private Tuple<NodeFormal, NodeExpression>[] branches;

    public NodeCase(NodeExpression expr0, Tuple<NodeFormal, NodeExpression>[] branches)
    {
        this.expr0 = expr0;
        this.branches = branches;
    }
}
