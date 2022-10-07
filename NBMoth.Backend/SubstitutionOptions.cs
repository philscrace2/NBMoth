public class SubstitutionOptions {
    private readonly TranslationOptions lhs;
    private readonly TranslationOptions rhs;

    public SubstitutionOptions(TranslationOptions lhs, TranslationOptions rhs) {
        this.lhs = lhs;
        this.rhs = rhs;
    }

    public TranslationOptions getLhs() {
        return lhs;
    }

    public TranslationOptions getRhs() {
        return rhs;
    }

}
