namespace MyLeetCode.arrays;
public class L242
{
    public bool IsAnagram(string s, string t)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        string sortedStr = new string(chars);

        char[] chars2 = t.ToCharArray();
        Array.Sort(chars2);
        string sortedStr2 = new string(chars2);

        if (sortedStr != sortedStr2)
        {
            return false;
        }
        return true;
    }
}
