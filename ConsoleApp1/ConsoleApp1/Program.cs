using System;
using System.Linq;

class AnagramChecker
{
    static void Main(string[] args)
    {
        string s = "silent";
        string t = "listen";
        bool result = IsAnagram(s, t);
        Console.WriteLine(result); 
    }

    static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();
        Array.Sort(sChars);
        Array.Sort(tChars);
        string sortedS = new string(sChars);
        string sortedT = new string(tChars);

        return sortedS == sortedT;
    }
}