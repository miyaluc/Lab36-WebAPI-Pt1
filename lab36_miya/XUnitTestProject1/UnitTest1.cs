using lab36_miya.Controllers;
using lab36_miya.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetReturnsOKWithIntArgument()
        {
            //Arrange
            var controller = new CoursesController();

            //Act
            var result = controller.Get(1);

            //Assert
            Assert.IsType(typeof(int), result);
        }

        [Fact]
        public void IDIsAnInt()
        {
            //Arrange
            var newID = new RequiredCoursework();

            //Act
            var result = newID.ID;

            //Assert
            Assert.IsType(typeof(int), result);
        }

        [Fact]
        public void ClassPropertyIsAString()
        {
            //Arrange
            var firstPeriod = new RequiredCoursework();

            //Act
            var result = firstPeriod.Class;

            //Assert
            Assert.IsType(typeof(string), result);
        }
    }
}
