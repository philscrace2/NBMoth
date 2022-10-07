package de.bmoth.backend.ltl.transformation;

import de.bmoth.parser.ast.nodes.Node;
import de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode;
import de.bmoth.parser.ast.visitors.ASTTransformation;

import static de.bmoth.backend.ltl.LTLTransformationUtil.contains;
import static de.bmoth.backend.ltl.LTLTransformationUtil.isOperator;
import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.FINALLY;
import static de.bmoth.parser.ast.nodes.ltl.LTLPrefixOperatorNode.Kind.GLOBALLY;

public class ConvertGloballyFinallyGloballyToFinallyGlobally implements ASTTransformation {

    @Override
    public boolean canHandleNode(Node node) {
        return isOperator(node, GLOBALLY) && contains(node, FINALLY, GLOBALLY);
    }

    @Override
    public Node transformNode(Node node) {
        LTLPrefixOperatorNode globallyOperator = (LTLPrefixOperatorNode) node;
        return globallyOperator.getArgument();
    }
}
