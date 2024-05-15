using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;


Console.WriteLine(Email.Matcher().IsMatch("sinan.nar@gmail.com"));
Console.WriteLine(Email.Matcher().IsMatch("sinan.nar@gmail......com"));

static partial class Email
{
    /// GE
    /// <remarks>
    /// Pattern:<br/>
    /// <code>^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$</code><br/>
    /// Explanation:<br/>
    /// <code>
    /// ○ Match if at the beginning of the string.<br/>
    /// ○ Match a character in the set [-.0-9A-Z_a-z] atomically at least once.<br/>
    /// ○ Match '@'.<br/>
    /// ○ Match a character in the set [-.0-9A-Za-z] greedily at least once.<br/>
    /// ○ Match '.'.<br/>
    /// ○ Match a character in the set [A-Za-z] atomically at least 2 and at most 4 times.<br/>
    /// ○ Match if at the end of the string or if before an ending newline.<br/>
    /// </code>
    /// </remarks>
    [GeneratedRegex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$")]
    public static partial Regex Matcher();
}

//Stopwatch sw = new();
//for (int i = 1; i<28;++i)
//{
//    Regex r = new Regex($@"^(\w\d|\d\w){{{i}}}$", RegexOptions.Compiled);
//    //Regex r = new Regex($@"^(\w\d|\d\w){{{i}}}\1$", RegexOptions.NonBacktracking);

//    string input = string.Concat(Enumerable.Repeat("11", i)) + "1";
//    sw.Restart();
//    r.IsMatch(input);
//    sw.Stop();
//    Console.WriteLine($"{i}: {sw.Elapsed}");
//}

//Example.Demo().Count("abc");
//static partial class Example
//{

//    [GeneratedRegex("a*[ab]")]
//    public static partial Regex Demo();

//    [GeneratedRegex("a*b")]
//    public static partial Regex Demo2();
//}


//Regex r = new Regex("abc");
//string input = "Hello,  abc! def how are you?";
//Console.WriteLine(r.IsMatch(input));
//Console.WriteLine(input.Contains("abc"));
//Console.WriteLine(input.IndexOf("abc") >= 0);



//string input = "Hello, abc is coming to work today";

//Regex regex1 = new Regex(@"abc|def"); // checking if "abc" or "def" exist in context
//Console.WriteLine(regex1.IsMatch(input));
//Console.WriteLine(regex1.Match(input));

//Regex regex2 = new Regex(@"^abc|def"); // checking if "abc" only at the beginning, or "def" exist in context
//Console.WriteLine(regex2.IsMatch(input));
//Console.WriteLine(regex2.Match(input));

//Regex regex3 = new Regex(@"^(abc|def)"); // checking if "abc" or "def" exist only at the beginning in context
//Console.WriteLine(regex2.IsMatch(input));
//Console.WriteLine(regex2.Match(input));

//Regex find_abc = new Regex(@"abc");
//Console.WriteLine("find_abc.IsMatch(abcccc): " + find_abc.IsMatch("abcccc"));
//Console.WriteLine("find_abc.IsMatch(aaa): " + find_abc.IsMatch("aaa"));
//Console.WriteLine("find_abc.IsMatch(aaabbbccc): " + find_abc.IsMatch("aaabbbccc"));
//Console.WriteLine();

//Regex find_abc_or_def = new Regex(@"abc|def");
//Console.WriteLine("find_abc_or_def.IsMatch(abcccc): " + find_abc_or_def.IsMatch("abcccc"));
//Console.WriteLine("find_abc_or_def.IsMatch(abc): " + find_abc_or_def.IsMatch("abc"));
//Console.WriteLine("find_abc_or_def.IsMatch(def): " + find_abc_or_def.IsMatch("def"));
//Console.WriteLine("find_abc_or_def.IsMatch(aaa): " + find_abc_or_def.IsMatch("aaa"));
//Console.WriteLine("find_abc_or_def.IsMatch(abcdef): " + find_abc_or_def.IsMatch("abcdef"));
//Console.WriteLine();

//Regex find_anynumberberofafollowedbyb = new Regex(@"a*b");
//Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(aaaaabbbbb): " + find_anynumberberofafollowedbyb.IsMatch("aaaaabbbbb"));
//Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(aaaaab): " + find_anynumberberofafollowedbyb.IsMatch("aaaaab"));
//Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(abbbb): " + find_anynumberberofafollowedbyb.IsMatch("abbbb"));
//Console.WriteLine();


//// parameter colored as regex
//static void FunctionTakesRegexArgument([StringSyntax(StringSyntaxAttribute.Regex)] string s) { }
//FunctionTakesRegexArgument(@"\b\w{5}\b");


//// parameter colored as json
//static void FunctionTakesJsonArgument([StringSyntax(StringSyntaxAttribute.Json)] string s) { }
//FunctionTakesJsonArgument("""
//    {
//        "key1": 3,
//        "key2": 12,
//        "key3": {
//            "key1": 3,
//            "key2": 12
//        },
//        "key4": [
//            {    
//                "key1": 3,
//                "key2": 12
//            },
//            {    
//                "key1": 3,
//                "key2": 12
//            }
//        ]
//    }
//    """);


//var regex = new Regex("a*c");
//string input = "Hello, aaaaac is coming to work today";
//Console.WriteLine(regex.IsMatch(input));