using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeIntConstant : NodeExpression
{

    private int value;

    public NodeIntConstant(int value)
    {
        this.value = value;
    }

}
