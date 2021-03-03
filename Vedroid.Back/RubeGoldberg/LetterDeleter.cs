using System;
using System.Linq;

namespace RubeGoldberg
{
    public static class LetterDeleter
    {
        public static string Delete(string str, params char[] chars)
        {
            return str is null ? "String is null" : chars.Aggregate(str, (current, ch) => current.Replace(ch.ToString(), string.Empty));
        }
    }
}