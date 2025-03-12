using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(arr);
        Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", arr));
    }
}
