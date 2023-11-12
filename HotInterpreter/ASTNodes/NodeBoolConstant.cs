using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeBoolConstant : NodeExpression
{

    private bool value;

    public NodeBoolConstant(bool value)
    {
        this.value = value;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Bool Constant:");
        csb.ChangeIndent(1);
        csb.AppendLine("Value: " + value);
        csb.ChangeIndent(-1);
    }
}
