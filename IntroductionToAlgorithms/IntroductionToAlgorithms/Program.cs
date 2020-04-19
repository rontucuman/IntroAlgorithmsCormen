using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionToAlgorithms.Chapter2.Exercises;

namespace IntroductionToAlgorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] A = new[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
      int[] A = new[] {45,21,89,32,74,58,41,20,69,52,21,46};

      Exercise2_3_6_InsertionSortRecursive bs = new Exercise2_3_6_InsertionSortRecursive();

      Console.WriteLine(GetArrayAsString("", A));

      bs.Process(A);

      Console.WriteLine(GetArrayAsString("", A));
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
