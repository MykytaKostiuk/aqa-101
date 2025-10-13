using System;


namespace HelloSofiia
{
    public enum Order
    {
        Desc,
        Asc
    }

    internal class SortArray
    {

        public static void ArraysGenerator(int min, int max, int[] newArray, Random random)
        {
            for (int a = 0; a < newArray.Length; a++)
            {
                newArray[a] = random.Next(min, max);
                Console.Write(newArray[a] + ",");
            }
        }


        public static int[] Sorting(int[] randomArray, Order myOrder)
        {
            int[] sortedArray = new int[randomArray.Length];
            randomArray.CopyTo(sortedArray, 0);

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                for (int j = 0; j < sortedArray.Length - i - 1; j++)
                {
                    bool isJGreaterThenJ1 = sortedArray[j] > sortedArray[j + 1];
                    bool isJ1GreaterThenJ = sortedArray[j] < sortedArray[j + 1];
                    bool isNeedToReplace = myOrder == Order.Asc ? isJGreaterThenJ1 : isJ1GreaterThenJ;
                    if (isNeedToReplace)
                    {
                        // Below we replace [A, B] => [B, A]
                        int temporaryValue = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temporaryValue;
                    }

                    //if (myOrder == Order.Asc)
                    //{
                    //    if (sortedArray[j] > sortedArray[j + 1])
                    //    {
                    //        int temporaryValue = sortedArray[j];
                    //        sortedArray[j] = sortedArray[j + 1];
                    //        sortedArray[j + 1] = temporaryValue;
                    //    }
                    //}

                    //if (myOrder == Order.Desc)
                    //{
                    //    if (sortedArray[j] < sortedArray[j + 1])
                    //    {
                    //        int temporaryValue = sortedArray[j];
                    //        sortedArray[j] = sortedArray[j + 1];
                    //        sortedArray[j + 1] = temporaryValue;
                    //    }
                    //}
                }
            }
            return sortedArray;

        }

        public static void Start()

        {
            int minValue = 0;
            int maxValue = 100;

            int[] NotSortedArray = new int[15];

            Random randomNumbers = new Random();

            ArraysGenerator(minValue, maxValue, NotSortedArray, randomNumbers);

            Console.WriteLine();

            int[] sortedArray = Sorting(NotSortedArray, Order.Desc);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + ",");
            }

        }
    }
}
