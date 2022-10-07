public class TranslationOptions {
    public static readonly TranslationOptions UNPRIMED = new TranslationOptions();
    public static readonly TranslationOptions PRIMED_0 = new TranslationOptions(0);

    private int primeLevel;
    private readonly bool hasPrimeLevel;

    private TranslationOptions() {
        this.hasPrimeLevel = false;
    }

    public TranslationOptions(int primeLevel) {
        this.hasPrimeLevel = true;
        this.primeLevel = primeLevel;
    }

    public int getPrimeLevel() {
        return primeLevel;
    }

    public bool isHasPrimeLevel() {
        return hasPrimeLevel;
    }

    
    public override string ToString() {
        return hasPrimeLevel ? "prime level " + primeLevel : "not primed";
    }
}
