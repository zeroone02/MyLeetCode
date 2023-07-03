using MyLeetCode.linkedlist;
using MyLeetCode.Tree;
using System.Collections.Generic;
using System.Text.RegularExpressions;

static bool IsPalindrome(string s)
{
    Regex reg = new Regex("[^a-zA-Z']");
    string s3 = reg.Replace(s, string.Empty);
    s3 = s3.ToLower();
 
    string str2 = "";
    for (int i = s3.Length - 1; i >= 0; i--)
    {
        str2 += s3[i];
    }
    if (str2 == s3) return true;
    return false;
}
string s = "0P";
IsPalindrome(s);