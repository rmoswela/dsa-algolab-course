using dsa_algolab_course;
using NUnit.Framework;

namespace dsa_algolab_tests
{
  [TestFixture]
  public class PalindromeTests
  {
    [Test]
    [TestCase(10)]
    public void Palindrom_Ten_ReturnFalse(int value)
    {
      //Arrange
      var exercise = new WarmUpExercises();
      //Act
      var actual = exercise.Palindrome(value);
      //Assert
      Assert.IsFalse(actual);
    }

    [Test]
    [TestCase(3)]
    public void Palindrom_Three_ReturnTrue(int value)
    {
      //Arrange
      var exercise = new WarmUpExercises();
      //Act
      var actual = exercise.Palindrome(value);
      //Assert
      Assert.IsTrue(actual);
    }

    [Test]
    [TestCase(12821)]
    public void Palindrom_TwelveThousandEighthundredAndTwentyOne_ReturnTrue(int value)
    {
      //Arrange
      var exercise = new WarmUpExercises();
      //Act
      var actual = exercise.Palindrome(value);
      //Assert
      Assert.IsTrue(actual);
    }
  }
}
