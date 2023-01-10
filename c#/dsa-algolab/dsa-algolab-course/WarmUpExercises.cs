namespace dsa_algolab_course
{
  public class WarmUpExercises
  {
    /// <summary>
    /// Given an integer n, return a string array answer (1-indexed) where:
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i (as a string) if none of the above conditions are true.
    /// Constraints: 1 <= n <= 104
    /// </summary>
    /// <param name="number">This method takes an interger</param>
    /// <returns>This method returns an array of strings</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public string[] FizzBuzz(int number)
    {
      if (number < 1 || number > 104)
      {
        throw new ArgumentOutOfRangeException("n should be greater or equal to 1 and less or equal to 104!");
      }

      List<string> list = new List<string>();

      for (int count = 1; count <= number; count++) {
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
    /// <summary>
    /// Given an integer x, return true if x is a palindrome and false otherwise.
    /// </summary>
    /// <param name="number">This method takes in an interger</param>
    /// <returns>This method returns a boolean</returns>
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