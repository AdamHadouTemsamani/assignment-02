using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri) => uri.ToString().StartsWith("https");
    
    public static int WordCount(this string s) => Regex.Split(s, @"[^\p{L}]*\p{Z}[^\p{L}]*").Length;
    
    
    
    


}
