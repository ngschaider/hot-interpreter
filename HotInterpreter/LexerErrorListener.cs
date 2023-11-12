using Antlr4.Runtime;

public class LexerErrorListener : IAntlrErrorListener<int>
{
    List<string> errors = new List<string>();

    public LexerErrorListener()
    {
    }

    public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        string error = $"L({line}, {charPositionInLine + 1}): {msg}";
        throw new ParsingException(error);

        //errors.Add(error);
    }
}