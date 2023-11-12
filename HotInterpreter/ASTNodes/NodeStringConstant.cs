using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeStringConstant : NodeExpression
{

    private string value;

    public NodeStringConstant(string value)
    {
        this.value = value;
    }

}
