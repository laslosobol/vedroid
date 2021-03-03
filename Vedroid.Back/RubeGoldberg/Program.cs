using System;

namespace RubeGoldberg
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Addition.Add());
            Console.WriteLine(Addition.Add(1, 5, 6, 7, 10));
            Console.WriteLine(StringConcatenation.Concatenate());
            Console.WriteLine(StringConcatenation.Concatenate("Concat", "these", "strings"));
            Console.WriteLine(LetterDeleter.Delete("Test String", 'e', 's', 'i'));
            Console.WriteLine(LetterDeleter.Delete(null, 'e', 's', 'i'));
        }
    }
}