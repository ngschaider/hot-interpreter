public class Scope {
    
    List<NodeId> symbols = new List<NodeId>();

    public bool HasSymbol(string name) {
        return FindSymbol(name) != null;
    }

    public NodeId? FindSymbol(string name) {
        return symbols.FirstOrDefault(symbol => symbol.name == name);
    }

    public void AddSymbol(NodeId symbol) {
        if(HasSymbol(symbol.name)) return;
        symbols.Add(symbol);
    }

    public void RemoveSymbol(NodeId symbol) {
        symbols.Remove(symbol)
    }

}