using System;


namespace HelloSofiia
{
    public class TaskWithLoops
    {
        public static int[] FindCommonNumbers(int[] firstArray, int[] secondArray)
        {
            int resultLength = Math.Max(firstArray.Length, secondArray.Length);

            int[] result = new int[resultLength];

            for (int x = 0; x < firstArray.Length; x++)
            {
                for (int y = 0; y < secondArray.Length; y++)

                {
                    if (firstArray[x] == secondArray[y])
                    {
                        int num = secondArray[y];
                        result[x] = num;
                    }
                }
            }
            return result;
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
            int[] arrayB = new int[10];

            int minArray = 1;
            int maxArray = 30;

            Random forRandNumbers = new Random();

            ArraysGenerator(minArray, maxArray, arrayA, forRandNumbers);
            Console.WriteLine();
            ArraysGenerator(minArray, maxArray, arrayB, forRandNumbers);
            Console.WriteLine();


            int[] resultArray = FindCommonNumbers(arrayA, arrayB);

            foreach (int numResult in resultArray)
            {
                if (numResult != 0)
                {
                    Console.WriteLine(numResult);
                }

            }
        }
    }
}
