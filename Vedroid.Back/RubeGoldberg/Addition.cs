using System;
using System.Linq;

namespace RubeGoldberg
{
    public static class Addition
    {
        public static int Add(params int[] numbers)
        {
            return numbers?.Sum() ?? 0;
        }
        public static int AddForeach(params int[] numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }
        public static decimal AddGeneric<T>(T first, T second)
        {
            var f = Convert.ToDecimal(first);
            var s = Convert.ToDecimal(second);
            return f + s;
        }
        public static int AddUnboxing(params object[] numbers)
        {
            var result = 0;
            foreach (var obj in numbers)
            {
                result += (int) obj;
            }
            return result;
        }
    }
}