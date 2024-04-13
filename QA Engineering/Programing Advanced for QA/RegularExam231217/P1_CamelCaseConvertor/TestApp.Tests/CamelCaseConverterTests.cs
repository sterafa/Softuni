using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "hello";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.AreEqual("hello", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "hello world";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.AreEqual("helloWorld", result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "HeLLo WOrld";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.AreEqual("helloWorld", result);
    }
}
