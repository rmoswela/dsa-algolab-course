using dsa_algolab_course;
using NUnit.Framework;

namespace dsa_algolab_tests
{
  [TestFixture]
  public class FizzBuzzTests
  {

    [Test]
    [TestCase(105)]
    public void FizzBuzz_InvalidArgument_ThrowArgumentOutRangeException(int number)
    {
      //Arrange
      var exercise = new WarmUpExercises();
      //Act and Assert
      Assert.Throws<ArgumentOutOfRangeException>(() => exercise.FizzBuzz(number));
    }

    [Test]
    [TestCase(15)]
    public void FizzBuzz_ValidArgument_ReturnArrayOfStrings(int number)
    {
      //Arrange
      var expected = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
      var exercise = new WarmUpExercises();
      //Act
      var actual = exercise.FizzBuzz(number);
      //Assert
      Assert.That(actual, Is.EqualTo(expected));
    }
  }
}