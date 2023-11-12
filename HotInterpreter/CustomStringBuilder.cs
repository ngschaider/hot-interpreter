using System.Text;
using Antlr4.Runtime.Atn;

public class CustomStringBuilder {

    private readonly StringBuilder sb = new StringBuilder();
    private int indent;

    void Append(string value) => sb.Append(value);

    public void AppendLine(string value) {
        for(int i = 0; i < this.indent; i++) {
            Append("    ");
        }
        sb.AppendLine(value);
    }

    public void ChangeIndent(int value) {
        indent += value;
    }

    public override string ToString()
    {
        return sb.ToString();
    }

}