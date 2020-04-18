using System;
using System.Text;

namespace Chapter_2
{
  public class InsertionSort
  {
    public void Process(int[] input)
    {
      int r = input.Length;

      SortRecursive(input, r);
    }
    
    private void SortRecursive(int[] input, int r)
    {
      if (r - 1 > 0)
      {
        SortRecursive(input, r - 1);
        InsertionRecursive(input,r - 1);
      }  
    }
    // 8-5 i=1 value=5
    private void InsertionRecursive(int[] input, int i)
    {

      if (i - 1 >= 0)
      {
        if (input[i - 1] > input[i])
        {
          int temp = input[i - 1];
          input[i - 1] = input[i];
          input[i] = temp;
        }

        InsertionRecursive(input, i - 1);
      }
    }

    private void InsertionSortAsc(int[] input)
    {
      for (int j = 1; j < input.Length; j++)
      {
        int key = input[j];
        int i = j - 1;

        while (i >= 0 && input[i] > key)
        {
          input[i + 1] = input[i];
          i = i - 1;
        }

        input[i + 1] = key;
        Console.WriteLine(GetArrayAsString("", input));
      }
    }

    private string GetArrayAsString(string prefix, int[] input)
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