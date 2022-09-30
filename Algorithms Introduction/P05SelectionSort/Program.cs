using System;

namespace P05SelectionSort
{
    class Program
    {
        private const int KEY_NOT_FOUND = -1;
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 2, 1, 1, 7 };
            int searchElement = int.Parse(Console.ReadLine());
            //SelectionSort(arr);
            BubbleSort(arr);
            Console.WriteLine(BinarySearch(arr, searchElement, 0, arr.Length));
            Console.WriteLine(String.Join(" ", arr));

            //1, 1, 2, 5, 6, 7
        }

        public static int BinarySearch(int[] arr, int searchElement, int left, int right) 
        {
            while(right >= left)
            {
                int midElement = (left + right) / 2;
                if (arr[midElement] < searchElement)
                {
                    left = midElement + 1;
                }
                else if (searchElement< arr[midElement]) 
                {
                    right = midElement - 1;
                }
                else 
                {
                    return midElement;
                }
            }

            return KEY_NOT_FOUND;
        }
        private static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
