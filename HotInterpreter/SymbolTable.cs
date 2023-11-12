using System.Collections;

public class SymbolTable {

    private Stack<Scope> stack = new Stack<Scope>();

    public void AddSymbol(NodeId symbol) {
        stack.Last().AddSymbol(symbol);
    }

    public NodeId? FindSymbol(string name) {
        return stack.FirstOrDefault(stack => stack.HasSymbol(name))?.FindSymbol(name);
    }

    public void RemoveSymbol(NodeId symbol) {
        throw new NotImplementedException();
    }

    public void EnterScope() {
        stack.Push(new Scope());
    }

    public void ExitScope() {
        stack.Pop();
    }

}