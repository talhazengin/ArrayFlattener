using System;
using System.Collections.Generic;

namespace ArrayFlattener
{
    internal class Program
    {
        // Write some code, that will flatten an array of
        // arbitrarily nested arrays of integers into a flat array of integers.e.g.
        // [[1, 2,[3]],4] -> [1,2,3,4]. 

        private static void Main()
        {
            object[] nestedIntegerArrays = { new object[] { 2, 3, new object[] { 2, 3 }, 7 }, 8, 9, new object[] { 55, new object[] { 7, 2 } }, new object[] { 2, 91 } };

            var flattenedList = new List<int>();

            RecursiveFlatten(nestedIntegerArrays, flattenedList);

            foreach (int number in flattenedList)
            {
                Console.WriteLine(number);
            }
        }

        public static void RecursiveFlatten(object nested, List<int> flattenedList)
        {
            if (nested is object[] nestedArray)
            {
                foreach (object nestedObject in nestedArray)
                {
                    RecursiveFlatten(nestedObject, flattenedList);
                }
            }

            if (nested is int number)
            {
                flattenedList.Add(number);
            }
        }
    }
}
