namespace NBMoth.Parser.ast.nodes {

//import org.antlr.v4.runtime.tree.ParseTree;

public abstract class ExprNode : TypedNode implements Node {

    public ExprNode(ParseTree parseTree) {
        super(parseTree);
    }

}


}
