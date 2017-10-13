namespace NumerologyKata
{
    public interface ReplaceRule
    {
        bool Matches(int number);
        int[] Replace(int[] input, int index);
    }
}