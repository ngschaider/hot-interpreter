using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeBoolConstant : NodeExpression
{

    private bool value;

    public NodeBoolConstant(bool value)
    {
        this.value = value;
    }

}
