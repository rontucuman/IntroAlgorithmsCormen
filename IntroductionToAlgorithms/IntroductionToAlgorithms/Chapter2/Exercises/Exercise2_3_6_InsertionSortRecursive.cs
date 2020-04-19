using System.CodeDom.Compiler;

namespace IntroductionToAlgorithms.Chapter2.Exercises
{
  public class Exercise2_3_6_InsertionSortRecursive
  {
    public int[] Process(int[] input)
    {
      InsertionSort(input);

      return input;
    }

    private void InsertionSort(int[] input)
    {
      for (int j = 1; j < input.Length; j++)
      {
        int key = input[j];
        int i = j - 1;

        //InsertionSortRecursive(i, key, input);
        InsertionSortWithBinarySearch(input, 0, i, key, i);
      }
    }

    private void InsertionSortWithBinarySearch(int[] input, int begin, int end, int key, int globalEnd)
    {
      int midPoint = begin + ((end - begin) / 2);

      if ((input[midPoint] == key) || (input[midPoint] >= key && begin >= end))
      {
        int temp = 0;

        for (int i = midPoint; i <= globalEnd + 1; i++)
        {
          temp = input[i];
          input[i] = key;
          key = temp;
        }
      }
      else
      {
        if (input[midPoint] > key)
        {
          InsertionSortWithBinarySearch(input, begin, midPoint - 1, key, globalEnd);
        }
        else
        {
          InsertionSortWithBinarySearch(input, midPoint + 1, end, key, globalEnd);
        }
      }
    }

    private void InsertionSortRecursive(int i, int key, int[] input)
    {
      if (i >= 0 && input[i] > key)
      {
        input[i + 1] = input[i];
        input[i] = key;

        InsertionSortRecursive(i - 1, key, input);
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
        
        
      }
    }
  }
}