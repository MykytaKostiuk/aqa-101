using System;
using System.Linq;



namespace HelloSofiia
{
    public class TaskWithJoinArrays
    {
        public static int[] GetUniqueItems(int[] ArrayWithDuplicates)
        {
            int[] result = new int[ArrayWithDuplicates.Length];
            int count = 0;

            for (int x = 0; x < ArrayWithDuplicates.Length; x++)
            {
                int times = GetTimesInArray(ArrayWithDuplicates[x], result);
                if (times == 0)
                {
                    result[count] = ArrayWithDuplicates[x];
                    count++;
                }
            }
            return result;
        }

        private static int GetTimesInArray(int v, int[] array)
        {
            int count = 0;
            for (int x = 0; x < array.Length; x++)
            {
                if (v == array[x])
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] MergeArray(int[] firstArray, int[] secondArray)
        {
            int resultLength = firstArray.Length + secondArray.Length;
            int[] result = new int[resultLength];


            for (int x = 0; x < firstArray.Length; x++)
            {
                result[x] = firstArray[x];
            }

            for (int y = 0; y < secondArray.Length; y++)
            {
                result[firstArray.Length + y] = secondArray[y];
            }

            int[] unicItemsWithZero = GetUniqueItems(result);

            int numberOfZeros = GetTimesInArray(0, unicItemsWithZero);

            int lengthOfArray = unicItemsWithZero.Length - numberOfZeros;

            int[] unicItemsNoZero = new int[lengthOfArray];

            for (int x = 0; x < lengthOfArray; x++)
            {

                unicItemsNoZero[x] = unicItemsWithZero[x];
            }

            return unicItemsNoZero;
        }

        public static void ArraysGenerator(int min, int max, int[] newArray, Random random)
        {

            for (int a = 0; a < newArray.Length; a++)
            {
                newArray[a] = random.Next(min, max);
                Console.Write(newArray[a] + ", ");
            }
        }
        public static void Start()

        {
            int[] arrayA = new int[10];
            int[] arrayB = new int[15];


            int minArray = 1;
            int maxArray = 30;

            Random forRandNumbers = new Random();

            ArraysGenerator(minArray, maxArray, arrayA, forRandNumbers);
            Console.WriteLine();

            ArraysGenerator(minArray, maxArray, arrayB, forRandNumbers);
            Console.WriteLine();


            int[] result = MergeArray(arrayA, arrayB);
            for (int x = 0; x < result.Length; x++)
            {
                Console.Write(result[x]);
                Console.Write(", ");
            }

            int[] arrayResult = arrayA.Union(arrayB).ToArray();


            Console.WriteLine();

            for (int x = 0; x < arrayResult.Length; x++)
            {
                Console.Write(arrayResult[x]);
                Console.Write(", ");
            }
        }
    }
}
