using System;

namespace Artem_Topchii_Homework_4
{
    class Program
    {
        static int FindTheMinimumValue (int [] array)
        {
            int minValue = array[FindTheMinimumValueIndex(array)];

            return minValue;
        }

        static int FindTheMaximumValue(int[] array)
        {
            int maxValue = array[FindTheMaximumValueIndex(array)];

            return maxValue;
        }

        static int FindTheMinimumValueIndex(int[] array)
        {
            int minValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[minValueIndex] > array[i])
                {
                    minValueIndex = i;
                }
            }

            return minValueIndex;
        }

        static int FindTheMaximumValueIndex(int[] array)
        {
            int maxValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxValueIndex] < array[i])
                {
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        static int SumOfArrayElementsWithOddIndices(int[] array)
        {
            int result = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                result += array[i];
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

        static void Main()
        {
        }
    }
}
