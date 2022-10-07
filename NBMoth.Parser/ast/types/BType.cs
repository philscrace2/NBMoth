


namespace NBMoth.Parser.ast.types
{
    public interface BType
    {

        public BType unify(BType otherType);

        public bool unifiable(BType otherType);

        public bool contains(BType other);

        public bool isUntyped();

    }
}


