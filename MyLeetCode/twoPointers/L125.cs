namespace MyLeetCode.twoPointers;
public class L125
{
    public bool IsPalindrome(string s)
    {
        var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
        return clean.Reverse().SequenceEqual(clean);
    }
}
