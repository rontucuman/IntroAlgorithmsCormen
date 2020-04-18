using System;

namespace Chapter_2
{
  /**
   * 2.3 Merge Sort
   * This sorting method takes time O(n)
   */
  public class MergeSorter
  {
    public int[] Process(int[] input)
    {
      int p = 0;
      int r = input.Length - 1;

      Sort(input, p, r);

      return input;
    }

    private void Sort(int[] input, int p, int r)
    {
      if (p < r)
      {
        int q = (p + r) / 2;

        Sort(input, p, q);
        Sort(input, q + 1, r);
        Merge(input, p, q, r);
      }

    }

    private void Merge(int[] input, int p, int q, int r)
    {
      int n1 = q - p + 1;
      int n2 = r - q;

      int[] left = new int[n1 + 1];
      int[] right = new int[n2 + 1];
      
      int i, j = 0;
      for (i = 0; i < n1; i++)
      {
        left[i] = input[p + i];
      }

      for (j = 0; j < n2; j++)
      {
        right[j] = input[q + j + 1];
      }

      i = 0;
      j = 0;

      left[n1] = Int32.MaxValue;
      right[n2] = Int32.MaxValue;

      for (int k = p; k <= r; k++)
      {
        if (left[i] <= right[j])
        {
          input[k] = left[i];
          i++;
        }
        else
        {
          input[k] = right[j];
          j++;
        }
      }
      
    }
  }
}