namespace LiteDB
{
    internal static class StringExtensions
    {
        internal static bool IsNullOrWhiteSpace(this string inString)
        {
            if (inString == null) return true;
            foreach(var c in inString)
            {
                switch (c)
                {
                    case ' ':
                    case '\r':
                    case '\n':
                    case '\t':
                    case '\v':
                        break;

                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
