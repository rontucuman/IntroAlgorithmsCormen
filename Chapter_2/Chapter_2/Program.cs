using System;
using System.Text;

namespace Chapter_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] A = new[] { 3, 41, 52, 26, 38, 57, 9, 49 };
      //int[] A = new[] {8, 5, 1};
      Console.WriteLine(GetArrayAsString("",A));
      InsertionSort insertionSort = new InsertionSort();
      insertionSort.Process(A);
      Console.WriteLine(GetArrayAsString("",A));
      Console.ReadKey();
    }

    /**
     * Exercise 2.2-2
     * Selection Sort
     *
     * int[] a = new[] {45, 20, 18, 51, 8, 13};
     * SelectionSort(a);
     */
    public static void SelectionSort(int[] a)
    {
      for (int i = 0; i < a.Length - 1; i++)
      {
        int smallestIndex = i;
        int smallest = a[smallestIndex];

        int aux = a[i];

        for (int j = i + 1; j < a.Length; j++)
        {
          if (a[j] < smallest)
          {
            smallestIndex = j;
            smallest = a[j];
          }
        }

        a[i] = a[smallestIndex];
        a[smallestIndex] = aux;

        Console.WriteLine(GetArrayAsString($"\ti -> {i} ", a));
      }
    }

    /**
     * Exercise 2.1-4
     *
     * int[] a = new[] {1, 0, 1};
     * int[] b = new[] {0, 1, 0};
     * int[] sum = AddBinary(a, b);
     */
    public static int[] AddBinary(int[] a, int[] b)
    {
      int[] sum = new int[a.Length + 1];
      int carry = 0;
      int i = a.Length - 1;

      while (i >= 0)
      {
        int ri;
        int ai = a[i];
        int bi = b[i];
        int si = ai + bi + carry;

        switch (si)
        {
          case 2:
            ri = 0;
            carry = 1;
            break;
          case 3:
            ri = 1;
            carry = 1;
            break;
          default:
            ri = si;
            carry = 0;
            break;
        }

        sum[i + 1] = ri;

        i--;
      }

      sum[i + 1] = carry;

      return sum;
    }

    /**
     * Exercise 2.1-3
     *
     * int[] a = new[] {31, 41, 59, 26, 41, 58};
     * int value = 40;
     * int i = LinearSearch(a, value);
     */
    public static int LinearSearch(int[] input, int value)
    {
      int index = -1;
      int j = 0;

      while (index == -1 && j < input.Length)
      {
        if (input[j] == value)
        {
          index = j;
        }

        j++;
      }
      
      return index;
    }
    
    private static string GetArrayAsString(string prefix, int[] input)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append($"{prefix}");

      if (input == null)
      {
        sb.Append("NULL");
      }
      else
      {
        sb.Append("[ ");
        string comma = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
          sb.Append($"{comma}{input[i]}");
          comma = ", ";
        }

        sb.Append(" ]");
      }

      return sb.ToString();
    }
  }
}
