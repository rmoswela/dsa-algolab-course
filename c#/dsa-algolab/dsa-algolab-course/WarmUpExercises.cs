namespace dsa_algolab_course
{
  public class WarmUpExercises
  {
    public string[] FizzBuzz(int n)
    {
      if (n < 1 || n > 104)
      {
        throw new ArgumentOutOfRangeException("n should be greater or equal to 1 and less or equal to 104!");
      }

      List<string> list = new List<string>();

      for (int count = 0; count < n; count++) {
        if (n % 3 == 0 && n % 5 == 0)
        {
          list.Add("FizzBuzz");
        }
        else if (n % 3 == 0)
        {
          list.Add("Fizz");
        }
        else if (n % 5 == 0)
        {
          list.Add("Buzz");
        }
        else
        {
          list.Add(count.ToString());
        }
      }
      return list.ToArray();
    }
  }
}