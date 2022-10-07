//import de.bmoth.parser.ast.types.BType;

//import java.util.Observable;
//import java.util.Observer;

//import org.antlr.v4.runtime.tree.ParseTree;
using Antlr4.Runtime.Tree;

namespace NBMoth.Parser.ast.nodes {  
    

    public abstract class TypedNode : Node, Observer
    {

        private BType type;
        private readonly IParseTree parseTree;

        public TypedNode(IParseTree parseTree)
        {
            this.parseTree = parseTree;
        }

        public IParseTree getParseTree()
        {
            return this.parseTree;
        }

        public BType getType()
        {
            return type;
        }

        public bool isUntyped()
        {
            return type.isUntyped();
        }

        public void setType(BType type)
        {
            if (type != null && type instanceof Observable) {
                ((Observable)type).deleteObserver(this);
            }
            this.type = type;
            if (type instanceof Observable) {
                ((Observable)type).addObserver(this);
            }
        }        
        public override void update(Observable o, Object arg)
        {
            o.deleteObserver(this);
            setType((BType)arg);
        }
    }


}