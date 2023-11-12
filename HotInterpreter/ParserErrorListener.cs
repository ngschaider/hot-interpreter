using Antlr4.Runtime;

public class ParserErrorListener : BaseErrorListener
{
    public List<string> errors = new List<string>();

    public ParserErrorListener()
    {
    }

    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        string error = $"P({line}, {charPositionInLine + 1}): {msg}";
        throw new ParsingException(error);

        //errors.Add(error);
    }

}