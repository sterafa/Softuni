using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int>(), result);
    }

    [Test]
    public void Test_CountDigits_PositiveSingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 7;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int> { { 7, 1 } }, result);
    }

    [Test]
    public void Test_CountDigits_PositiveMultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 1223334444;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int>
        {
            { 1, 1 },
            { 2, 2 },
            { 3, 3 },
            { 4, 4 }
        }, result);
    }

    [Test]
    public void Test_CountDigits_NegativeSingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = -7;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int> { { 7, 1 } }, result);
    }

    [Test]
    public void Test_CountDigits_NegativeMultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -1223334444;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int>
        {
            { 1, 1 },
            { 2, 2 },
            { 3, 3 },
            { 4, 4 }
        }, result);
    }

    [Test]
    public void Test_CountDigits_LargePositiveNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 987654321;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 1 },
            { 4, 1 },
            { 5, 1 },
            { 6, 1 },
            { 7, 1 },
            { 8, 1 },
            { 9, 1 }
        }, result);
    }

    [Test]
    public void Test_CountDigits_LargeNegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -987654321;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEquivalent(new Dictionary<int, int>
        {
            { 1, 1 },
            { 2, 1 },
            { 3, 1 },
            { 4, 1 },
            { 5, 1 },
            { 6, 1 },
            { 7, 1 },
            { 8, 1 },
            { 9, 1 }
        }, result);
    }
}