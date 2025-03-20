using System;

class DynamicArray
{
    private int[] array;
    private int size;

    public DynamicArray(int capacity = 2)
    {
        array = new int[capacity];
        size = 0;
    }

    public void Add(int value)
    {
        if (size == array.Length)
        {
            int[] newArray = new int[array.Length * 2];
            Array.Copy(array, newArray, array.Length);
            array = newArray;
        }
        array[size++] = value;
    }

    public void Print()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        DynamicArray arr = new DynamicArray();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);
        arr.Print();
    }
}
