using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NodeParantheses : NodeExpression
{

    NodeExpression expression;

    public NodeParantheses(NodeExpression expression) {
        this.expression = expression;
    }

    public override void ToCustomStringBuilder(CustomStringBuilder csb)
    {
        csb.AppendLine("Expression - Parantheses:");
        csb.ChangeIndent(1);

        expression.ToCustomStringBuilder(csb);
        
        csb.ChangeIndent(-1);
    }

}

