using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class EmployeeManagementSystemTests
    {
        [Test]
        public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();

            // Assert
            Assert.AreEqual(0, empSystem.EmployeeCount);
            CollectionAssert.IsEmpty(empSystem.GetAllEmployees());
        }

        [Test]
        public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();

            // Act
            empSystem.AddEmployee("John Doe");

            // Assert
            Assert.AreEqual(1, empSystem.EmployeeCount);
            CollectionAssert.Contains(empSystem.GetAllEmployees(), "John Doe");
        }

        [Test]
        public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();

            // Assert
            Assert.Throws<ArgumentException>(() => empSystem.AddEmployee(null));
            Assert.Throws<ArgumentException>(() => empSystem.AddEmployee(""));
            Assert.Throws<ArgumentException>(() => empSystem.AddEmployee("   "));
        }

        [Test]
        public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();
            empSystem.AddEmployee("John Doe");
            empSystem.AddEmployee("Jane Smith");

            // Act
            empSystem.RemoveEmployee("John Doe");

            // Assert
            Assert.AreEqual(1, empSystem.EmployeeCount);
            CollectionAssert.DoesNotContain(empSystem.GetAllEmployees(), "John Doe");
        }

        [Test]
        public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();

            // Assert
            Assert.Throws<ArgumentException>(() => empSystem.RemoveEmployee(null));
            Assert.Throws<ArgumentException>(() => empSystem.RemoveEmployee(""));
            Assert.Throws<ArgumentException>(() => empSystem.RemoveEmployee("   "));
        }

        [Test]
        public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
        {
            // Arrange
            EmployeeManagementSystem empSystem = new EmployeeManagementSystem();
            empSystem.AddEmployee("John Doe");
            empSystem.AddEmployee("Jane Smith");
            empSystem.RemoveEmployee("John Doe");

            // Act
            List<string> allEmployees = empSystem.GetAllEmployees();

            // Assert
            Assert.AreEqual(1, allEmployees.Count);
            CollectionAssert.DoesNotContain(allEmployees, "John Doe");
            CollectionAssert.Contains(allEmployees, "Jane Smith");
        }
    }
}
