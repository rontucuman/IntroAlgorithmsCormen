namespace IntroductionToAlgorithms.Chapter2.Exercises
{
  public class Exercise2_3_5_BinarySearch
  {

    /**
     * Exercise 2.3-5 Binary Search
     * if the sequence is sorted then we can check the midpoint
     * against value to find and eliminate half of the sequence
     */
    public int Process(int[] sortedInput, int valueToSearch)
    {
      int foundIndex = BinarySearch(sortedInput, 0, sortedInput.Length, valueToSearch);

      return foundIndex;
    }

    private int BinarySearch(int[] input, int beginIndex, int endIndex, int value)
    {
      int midPoint = beginIndex + ((endIndex - beginIndex) / 2);
      int foundIndex = -1;

      if (input[midPoint] == value)
      {
        foundIndex = midPoint;
      }
      else
      {
        if (beginIndex == endIndex - 1)
        {
          foundIndex = -1;
        }
        else
        {
          if (input[midPoint] > value)
          {
            foundIndex = BinarySearch(input, beginIndex, midPoint, value);
          }
          else
          {
            foundIndex = BinarySearch(input, midPoint + 1, endIndex, value);
          }
        }
      }

      return foundIndex;
    }
  }
}