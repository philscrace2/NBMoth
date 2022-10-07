namespace NBMoth.Parser.ast.nodes{

//import org.antlr.v4.runtime.tree.TerminalNode;

public class DeclarationNode : TypedNode {

    private readonly string name;
    private readonly TerminalNode terminalNode;

    public DeclarationNode(TerminalNode terminalNode, string name) {
        base(terminalNode);
        this.name = name;
        this.terminalNode = terminalNode;
    }

    public string getName() {
        return name;
    }

    
    public override string ToString() {
        return name;
    }

    public int getLine() {
        return terminalNode.getSymbol().getLine();
    }

    public object getPos() {
        return terminalNode.getSymbol().getCharPositionInLine();
    }
    
    public override bool equalAst(Node other) {
        return NodeUtil.isSameClass(this, other)
            && this.name.equals(((DeclarationNode) other).name);
    }
}





}