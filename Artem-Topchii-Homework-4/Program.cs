using System;

namespace Artem_Topchii_Homework_4
{
    class Program
    {
        static int FindTheMinimumValue (int [] array)
        {
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        static int FindTheMaximumValue(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        static int FindTheMinimumValueIndex(int[] array)
        {
            int minValue = array[0];
            int minValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                    minValueIndex = i;
                }
            }

            return minValueIndex;
        }

        static int FindTheMaximumValueIndex(int[] array)
        {
            int maxValue = array[0];
            int maxValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        static int SumOfArrayElementsWithOddIndices(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result += array[i];
                }
            }

            return result;
        }

        static int[] ReverseArray(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                SwapTwoValues(ref array[j], ref array[i]);
            }

            return array;
        }

        static int CountOfOddArrayElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int[] SwapTheFirstAndSecondHalfOfTheArray(int[] array)
        {
            for (int i = 0, j = (array.Length - array.Length / 2); i < array.Length / 2; i++, j++)
            {
                SwapTwoValues(ref array[i], ref array[j]);
            }

            return array;
        }

        static int[] SortTheArrayInAscendingOrder(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        SwapTwoValues(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        static int[] SortTheArrayInDescendingOrder(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                
                if (maxIndex != i)
                {
                    SwapTwoValues(ref array[i], ref array[maxIndex]);
                }
            }

            return array;
        }

        static (int, int) SwapTwoValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
        }

        static void Main(string[] args)
        {

            //FILL ARRAY WITH RANDOM VALUE

                int beginningOfTheRange = -5;
                int endOfTheRange = 10;
                int length = 9;
                int[] randomArray = new int[length];
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    randomArray[i] = random.Next(beginningOfTheRange, endOfTheRange);
                }

            //FIND THE MINIMUM VALUE

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Min value of an array - " + FindTheMinimumValue(randomArray));

            //FIND THE MAXIMUM VALUE

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Max value of an array - " + FindTheMaximumValue(randomArray));

            //FIND THE MINIMUM VALUE INDEX

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(i + " - " + randomArray[i]);
                //}

                //Console.WriteLine("Min value index of an array - " + FindTheMinimumValueIndex(randomArray));

            //FIND THE MAXIMUM VALUE INDEX 

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(i + " - " + randomArray[i]);
                //}

                //Console.WriteLine("Max value index of an array - " + FindTheMaximumValueIndex(randomArray));

            //SUM OF ARRAY ELEMENTS WITH ODD INDICES

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(i + " - " + randomArray[i]);
                //}

                //Console.WriteLine("Sum of array elements with odd indices = " + SumOfArrayElementsWithOddIndices(randomArray));

            //REVERSE ARRAY

                //Console.WriteLine("Original array:");

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Reversed array:");

                //int [] array = ReverseArray(randomArray);

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(array[i]);
                //}

            //COUNT OF ODD ARRAY ELEMENTS

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Count of odd array elements - " + CountOfOddArrayElements(randomArray));

            //SWAP THE FIRST AND SECOND HALF OF THE ARRAY

                //Console.WriteLine("Original array:");

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Swapped array:");

                //int[] swappedArray = SwapTheFirstAndSecondHalfOfTheArray(randomArray);

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(swappedArray[i]);
                //}

            //SORT THE ARRAY IN ASCENDING ORDER 

                //Console.WriteLine("Original array:");

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}

                //Console.WriteLine("Sorted array:");

                //int[] array = SortTheArrayInAscendingOrder(randomArray);

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(array[i]);
                //}

            //SORT THE ARRAY IN DESCENDING ORDER 

                //Console.WriteLine("Original array:");

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(randomArray[i]);
                //}
                
                //Console.WriteLine("Sorted array:");

                //int[] array = SortTheArrayInDescendingOrder(randomArray);

                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(array[i]);
                //}
        }
    }
}
