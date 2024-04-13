using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //Arrange
        string input = "Desislava";
        string startMarker = "es";
        string endMarker = "va";

        //Act
        string actualResult = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        string expectedResult = "isla";

        //Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Desislava";
        string startMarker = "09";
        string endMarker = "va";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Desislava";
        string startMarker = "i";
        string endMarker = "09";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Desislava";
        string startMarker = "02";
        string endMarker = "09";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "";
        string startMarker = "02";
        string endMarker = "0x9";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "eedd";
        string startMarker = "ee";
        string endMarker = "ed";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
