using NBMoth.Parser.ast.visitors;
using NBMoth.Parser.ast.nodes;

namespace NBMoth.Backend.ltl.transformation {

//    package de.bmoth.backend.ltl.transformation;

//    import de.bmoth.parser.ast.nodes.Node;
//    import de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode;
//    import de.bmoth.parser.ast.visitors.ASTTransformation;

//    import static de.bmoth.backend.ltl.LTLTransformationUtil.contains;
//import static de.bmoth.backend.ltl.LTLTransformationUtil.isOperator;
//import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.FINALLY;
//import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.GLOBALLY;

public class ConvertFinallyGloballyFinallyToGloballyFinally : ASTTransformation
    {

        
    public bool canHandleNode(Node node)
    {
        return isOperator(node, FINALLY) && contains(node, GLOBALLY, FINALLY);
    }

    
    public Node transformNode(Node node)
    {
        LTLPrefixOperatorNode finallyOperator = (LTLPrefixOperatorNode)node;
        return finallyOperator.getArgument();
    }
}




}