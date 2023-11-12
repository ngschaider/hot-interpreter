using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeStringConstant : NodeExpression
{

    private string value;

    public NodeStringConstant(string value)
    {
        this.value = value;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - String Constant:");
        csb.ChangeIndent(1);

        csb.AppendLine("Value: " + value);
        
        csb.ChangeIndent(-1);
    }

}
