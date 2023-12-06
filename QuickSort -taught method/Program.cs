using System;

namespace QuickSort__taught_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 3, 7, 2, 4,3, 14, 8, 12, 6, 11, 1, -1 };
            printArray(numbers);
            quickSort(numbers,0,numbers.Length-1);
            //partition(numbers,0,numbers.Length-1);
            Console.WriteLine();
            printArray(numbers);
        }
        public static void quickSort(int[] data , int left, int right)
        { 
        if (left<right)
            {
                int pivotPosition = partition(data, left, right);
                quickSort(data, left, pivotPosition - 1);
                quickSort(data , pivotPosition+1,right);
            }
        }
        public static int partition(int[] aiData, int iLeft, int iRight)        
        {
            int iPivot;
            iPivot = aiData[iLeft];
            string stCurrentPointer = "Right";
            while(iLeft!=iRight)
            {
                if (stCurrentPointer =="Right")
                {
                    if (aiData[iRight]<iPivot)
                    {
                        aiData[iLeft] = aiData[iRight];
                        iLeft++;
                        stCurrentPointer = "Left";
                    }
                    else
                    {
                        iRight --;
                    }
                }
                else if(stCurrentPointer =="Left")
                {
                    if (aiData[iLeft] > iPivot)
                    {
                        aiData[iRight] = aiData[iLeft];
                        iRight--;
                        stCurrentPointer = "Right";
                    }
                    else
                    {
                        iLeft++;
                    }
                }
            }
            aiData[iLeft] = iPivot;
            return iLeft;
        
        }
        public static void printArray(int[] numbers)
        { for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
        }
    } 
}

