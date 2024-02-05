using NBMoth.Parser.ast.nodes;
using NBMoth.Parser.ast.visitors;


namespace NBMoth.Backend.ltl {

//    package de.bmoth.backend.ltl.transformation;

//    import de.bmoth.parser.ast.nodes.Node;
//    import de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode;
//    import de.bmoth.parser.ast.visitors.ASTTransformation;

//    import static de.bmoth.backend.ltl.LTLTransformationUtil.contains;
//import static de.bmoth.backend.ltl.LTLTransformationUtil.isOperator;
//import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.FINALLY;
//import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.NOT;

public class ConvertFinallyFinallyToFinally : ASTTransformation
    {

        
    public bool canHandleNode(Node node)
    {
        return isOperator(node, FINALLY) && (contains(node, FINALLY) || contains(node, NOT, FINALLY));
    }

    
    public Node transformNode(Node node)
    {
        LTLPrefixOperatorNode outerFinally = (LTLPrefixOperatorNode)node;
        return outerFinally.getArgument();
    }
}


}