using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class StringModifierTests
    {
        [Test]
        public void Test_Modify_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            string expectedOutput = "";

            // Act
            string result = StringModifier.Modify(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Modify_SingleWordWithEvenLength_ReturnsUpperCaseWord()
        {
            // Arrange
            string input = "test";
            string expectedOutput = "TEST";

            // Act
            string result = StringModifier.Modify(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
        {
            // Arrange
            string input = "SoftUni";
            string expectedOutput = "softuni";

            // Act
            string result = StringModifier.Modify(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Modify_MultipleWords_ReturnsModifiedString()
        {
            // Arrange
            string input = "SoftUni the best";
            string expectedOutput = "softuni the BEST";

            // Act
            string result = StringModifier.Modify(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
