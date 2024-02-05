using NBMoth.Parser.ast.nodes;

namespace NBMoth.Parser.ast.visitors {
    //package de.bmoth.parser.ast.visitors;

    //import de.bmoth.parser.ast.nodes.Node;

    public interface ASTTransformation
    {

        bool canHandleNode(Node node);

        Node transformNode(Node node);
    }




}