using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class SentenceAnalyzerTests
    {
        [Test]
        public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
        {
            // Arrange
            string input = "";
            Dictionary<string, int> expectedOutput = new Dictionary<string, int>();

            // Act
            Dictionary<string, int> result = SentenceAnalyzer.Analyze(input);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
        {
            // Arrange
            string input = "A";
            Dictionary<string, int> expectedOutput = new Dictionary<string, int>
            {
                {"letters", 1 }
            };

            // Act
            Dictionary<string, int> result = SentenceAnalyzer.Analyze(input);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
        {
            // Arrange
            string input = "5";
            Dictionary<string, int> expectedOutput = new Dictionary<string, int>
            {
                {"digits", 1 }
            };

            // Act
            Dictionary<string, int> result = SentenceAnalyzer.Analyze(input);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
        {
            // Arrange
            string input = "Unit testing is the 1st step!!!";
            Dictionary<string, int> expectedOutput = new Dictionary<string, int>
            {
                {"letters", 22 },
                {"digits", 1 },
                {"special characters", 3 }
            };

            // Act
            Dictionary<string, int> result = SentenceAnalyzer.Analyze(input);

            // Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }
    }
}
