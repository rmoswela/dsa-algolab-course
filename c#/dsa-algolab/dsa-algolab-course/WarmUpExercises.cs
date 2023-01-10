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

      for (int count = 1; count <= n; count++) {
        if (count % 3 == 0 && count % 5 == 0)
        {
          list.Add("FizzBuzz");
        }
        else if (count % 3 == 0)
        {
          list.Add("Fizz");
        }
        else if (count % 5 == 0)
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

    public bool Palindrome (int number)
    {
      int reverse = 0;
      var tempVal = number;
      while (tempVal != 0)
      {
        reverse = (reverse * 10) + (tempVal % 10);
        tempVal = tempVal / 10;
      }

      return (reverse == number);
    }
  }
}