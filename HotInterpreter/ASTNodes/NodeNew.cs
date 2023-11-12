using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeNew : NodeExpression
{

    private string type;

    public NodeNew(string type)
    {
        this.type = type;
    }
}
