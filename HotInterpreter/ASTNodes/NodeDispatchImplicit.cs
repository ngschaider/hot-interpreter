using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeDispatchImplicit : NodeExpression
{

    string methodName;
    NodeExpression[] formals;

    public NodeDispatchImplicit(string methodName, NodeExpression[] formals) {
        this.methodName = methodName;
        this.formals = formals;
    }

}
