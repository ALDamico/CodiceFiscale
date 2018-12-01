namespace libCodiceFiscale.Extensions
{
    public static class StringExtensions
    {
        public static string RemovePunctuationAndWhitespaces(this string s)
        {
            string output = s;
            foreach (char c in output)
            {
                if (char.IsPunctuation(c) || char.IsWhiteSpace(c))
                {
                    output = output.Replace(c.ToString(), "");
                }
            }
            return output;
        }
    }
}