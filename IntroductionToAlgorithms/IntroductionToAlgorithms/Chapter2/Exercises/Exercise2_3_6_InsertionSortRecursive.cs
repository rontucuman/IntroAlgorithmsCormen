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

        InsertionSortRecursive(i, key, input);
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