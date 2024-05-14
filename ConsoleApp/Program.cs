using System.Text.RegularExpressions;

//Regex regex = new Regex(@"\b\w{5}\b");
Regex find_abc = new Regex(@"abc");
Regex find_abc_or_def = new Regex(@"abc|def");
Regex find_anynumberberofafollowedbyb = new Regex(@"a*b");


Console.WriteLine("find_abc.IsMatch(abcccc): " + find_abc.IsMatch("abcccc"));
Console.WriteLine("find_abc.IsMatch(aaa): " + find_abc.IsMatch("aaa"));
Console.WriteLine("find_abc.IsMatch(aaabbbccc): " + find_abc.IsMatch("aaabbbccc"));
Console.WriteLine();

Console.WriteLine("find_abc_or_def.IsMatch(abcccc): " + find_abc_or_def.IsMatch("abcccc"));
Console.WriteLine("find_abc_or_def.IsMatch(abc): " + find_abc_or_def.IsMatch("abc"));
Console.WriteLine("find_abc_or_def.IsMatch(def): " + find_abc_or_def.IsMatch("def"));
Console.WriteLine("find_abc_or_def.IsMatch(aaa): " + find_abc_or_def.IsMatch("aaa"));
Console.WriteLine("find_abc_or_def.IsMatch(abcdef): " + find_abc_or_def.IsMatch("abcdef"));
Console.WriteLine();

Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(aaaaabbbbb): " + find_anynumberberofafollowedbyb.IsMatch("aaaaabbbbb"));
Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(aaaaab): " + find_anynumberberofafollowedbyb.IsMatch("aaaaab"));
Console.WriteLine("find_anynumberberofafollowedbyb.IsMatch(abbbb): " + find_anynumberberofafollowedbyb.IsMatch("abbbb"));
Console.WriteLine();
