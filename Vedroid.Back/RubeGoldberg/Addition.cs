using System.Linq;

namespace RubeGoldberg
{
    public static class Addition
    {
        public static int Add(params int[] numbers)
        {
            return numbers?.Sum() ?? 0;
        }
    }
}