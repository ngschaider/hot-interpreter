using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class NodeProgram : BaseNode
{

    private NodeClassDefine[] classDefines;

    public NodeProgram(NodeClassDefine[] classDefines)
    {
        this.classDefines = classDefines;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Program: ");
        csb.ChangeIndent(1);

        foreach(NodeClassDefine classDefine in classDefines) {
            classDefine.ToCustomStringBuilder(csb);
        }

        csb.ChangeIndent(-1);
    }

}
