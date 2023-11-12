using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class NodeProgram : BaseNode
{

    //private NodeFunction[] functions;
    //private NodeVariableDeclaration[] variables;
    private NodeClassDefine[] classDefines;


    public NodeProgram(NodeClassDefine[] classDefines)
    {
        this.classDefines = classDefines;
    }

}
