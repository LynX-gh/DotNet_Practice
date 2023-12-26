using System.Text;

string s = "The quick brown fox jumps over the lazy dog";

string[] words = s.Split(' ');
StringBuilder sb = new StringBuilder();

foreach (string word in words)
{
    for (int i = word.Length - 1; i >= 0; i--)
    {
        sb.Append(word[i]);
    }
    sb.Append(' ');
}
Console.WriteLine(sb.ToString().TrimEnd());