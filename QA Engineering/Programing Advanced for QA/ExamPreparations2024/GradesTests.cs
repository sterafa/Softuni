using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Ivan"] = 4,
            ["Peter"] = 6,
            ["Denis"] = 3,
            ["Martin"] = 2
        };

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary); //резултатът от изпълнения метод
        string expectedResult = "Peter with average grade 6.00"
                                + Environment.NewLine
                                + "Ivan with average grade 4.00"
                                + Environment.NewLine
                                + "Denis with average grade 3.00";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new Dictionary<string, int>(); //нов празен речник
        //Count = 0 -> брой записи

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary); //резултатът от изпълнения метод
        string expectedResult = "";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Ivan"] = 3,
            ["Peter"] = 4,
        };

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary); //резултатът от изпълнения метод
        string expectedResult = "Peter with average grade 4.00"
                                + Environment.NewLine
                                + "Ivan with average grade 3.00";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        //Arrange
        Dictionary<string, int> gradesDictionary = new()
        {
            ["Ivan"] = 4,
            ["Peter"] = 4,
            ["Georgi"] = 4,
            ["Aleks"] = 4,
            ["Martin"] = 4
        };

        //Act
        string actualResult = Grades.GetBestStudents(gradesDictionary); //резултатът от изпълнения метод
        string expectedResult = "Aleks with average grade 4.00"
                                + Environment.NewLine
                                + "Georgi with average grade 4.00"
                                + Environment.NewLine
                                + "Ivan with average grade 4.00";

        //Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}
