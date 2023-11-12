using Antlr4.Runtime;

if (args.Length == 0)
{
    Console.WriteLine("Usage: ./hot progam.cl");
    return;
}


StreamReader? streamReader = null;
try
{
    streamReader = new StreamReader(args[0]);
}
catch (FileNotFoundException)
{
    Console.WriteLine("File not found: " + args[0]);
    return;
}
catch (Exception e)
{
    Console.Write("Error while reading file: " + e.Message);
    return;
}
if (streamReader == null) { return; }

AntlrInputStream inputStream = new AntlrInputStream(streamReader);
CoolLexer lexer = new CoolLexer(inputStream);
CommonTokenStream tokenStream = new CommonTokenStream(lexer);

CoolParser parser = new CoolParser(tokenStream);
CoolParser.ProgramContext program = parser.program();

ASTBuilder builder = new ASTBuilder();
builder.VisitProgram(program);