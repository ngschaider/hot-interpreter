using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeParantheses : NodeExpression
{

    NodeExpression expression;

    public NodeParantheses(NodeExpression expression) {
        this.expression = expression;
    }

}
