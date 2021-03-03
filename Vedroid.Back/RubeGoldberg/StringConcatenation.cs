using System.Linq;

namespace RubeGoldberg
{
    public static class StringConcatenation
    {
        public static string Concatenate(params string[] strings)
        {
            return strings.Length == 0 ? "Empty" : strings.Aggregate("", (current, substring) => current + $"{substring}");
        }
    }
}