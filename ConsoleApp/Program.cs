using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;


Example.Demo().Count("abc");
static partial class Example
{
    /*
        // SPIT OUT CODE
        private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
        {
            int pos = base.runtextpos;
                    
            // Any possible match is at least 3 characters.
            if (pos <= inputSpan.Length - 3)
            {
                // The pattern has the literal "abc" at the beginning of the pattern. Find the next occurrence.
                // If it can't be found, there's no match.
                int i = inputSpan.Slice(pos).IndexOf("abc");
                if (i >= 0)
                {
                    base.runtextpos = pos + i;
                    return true;
                }
            }
                    
            // No match found.
            base.runtextpos = inputSpan.Length;
            return false;
        }
     */
    [GeneratedRegex("abc")]
    public static partial Regex Demo();

    /*
     // SPIT OUT CODE
        private bool TryFindNextPossibleStartingPosition(ReadOnlySpan<char> inputSpan)
        {
            int pos = base.runtextpos;
                    
            // Empty matches aren't possible.
            if ((uint)pos < (uint)inputSpan.Length)
            {
                // The pattern begins with a character in the set [ac].
                // Find the next occurrence. If it can't be found, there's no match.
                int i = inputSpan.Slice(pos).IndexOfAny('a', 'c');
                if (i >= 0)
                {
                    base.runtextpos = pos + i;
                    return true;
                }
            }
                    
            // No match found.
            base.runtextpos = inputSpan.Length;
            return false;
        }
     */
    [GeneratedRegex("a*c")]
    public static partial Regex Demo2();
}


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
