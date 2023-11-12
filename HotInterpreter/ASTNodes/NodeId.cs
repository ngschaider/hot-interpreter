using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeId : NodeExpression
{

    private string name;

    public NodeId(string name)
    {
        this.name = name;
    }

}
