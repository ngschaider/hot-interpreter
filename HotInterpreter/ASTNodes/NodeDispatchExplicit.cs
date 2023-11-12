using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class NodeDispatchExplicit : NodeExpression
{

    NodeExpression instance;
    string? targetClass;
    string methodName;
    NodeExpression[] formals;

    public NodeDispatchExplicit(NodeExpression instance, string? targetClass, string methodName, NodeExpression[] formals) {
        this.instance = instance;
        this.targetClass = targetClass;
        this.methodName = methodName;
        this.formals = formals;
    }

}
