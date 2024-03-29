using NBMoth.Parser.ast.visitors;
using NBMoth.Parser.ast.nodes;

namespace NBMoth.Backend.ltl.transformation {

//    package de.bmoth.backend.ltl.transformation;

//    import de.bmoth.parser.ast.nodes.Node;
//    import de.bmoth.parser.ast.nodes.ltl.LTLInfixOperatorNode;
//    import de.bmoth.parser.ast.nodes.ltl.LTLKeywordNode;
//    import de.bmoth.parser.ast.nodes.ltl.LTLNode;
//    import de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode;
//    import de.bmoth.parser.ast.visitors.ASTTransformation;

//    import static de.bmoth.backend.ltl.LTLTransformationUtil.isOperator;
//import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.FINALLY;

public class ConvertFinallyPhiToTrueUntilPhi : ASTTransformation
    {

       
    public bool canHandleNode(Node node)
    {
        return isOperator(node, FINALLY);
    }

    
    public Node transformNode(Node oldNode)
    {
        LTLPrefixOperatorNode finallyOperator = (LTLPrefixOperatorNode)oldNode;
        LTLNode argument = finallyOperator.getArgument();
        LTLKeywordNode trueNode = new LTLKeywordNode(LTLKeywordNode.Kind.TRUE);
        return new LTLInfixOperatorNode(LTLInfixOperatorNode.Kind.UNTIL, trueNode, argument);
    }
}






}
