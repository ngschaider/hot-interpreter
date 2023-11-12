using Antlr4.Runtime;

public static partial class Program {
    public static void Main(string[] args) {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: ./hot program.cl");
            return;
        }

        string path = Path.GetFullPath(args[0]);
        NodeProgram? program = BuildAST(path);
        if(program == null) return;

        Console.WriteLine(program.ToString());
    }

    public static StreamReader? GetStream(string path) {
        StreamReader? streamReader = null;
        try
        {
            streamReader = new StreamReader(path);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: " + path);
            return null;
        }
        catch (Exception e)
        {
            Console.Write("Error reading file: " + e.Message);
            return null;
        }
        if (streamReader == null) { 
            throw new Exception("StreamReader is null. How can this happen?");
        }
        return streamReader;
    }

    public static NodeProgram? BuildAST(string path) {
        StreamReader? reader = GetStream(path);
        if(reader == null) return null;

        AntlrInputStream inputStream = new AntlrInputStream(reader);
        CoolLexer lexer = new CoolLexer(inputStream);
        CommonTokenStream tokenStream = new CommonTokenStream(lexer);

        CoolParser parser = new CoolParser(tokenStream);
        CoolParser.ProgramContext program = parser.program();

        ASTBuilder builder = new ASTBuilder();
        NodeProgram nodeProgram = builder.VisitProgram(program);

        return nodeProgram;
    }
}



