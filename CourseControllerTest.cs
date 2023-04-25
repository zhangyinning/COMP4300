using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseRegistration.Controllers;
using CourseRegistration.Data;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using NuGet.ContentModel;

namespace CourseRegistrationTests.ControllerTests
{
    public class CourseControllerTest
    {
        [Fact]
        public async Task Index_NotNull_NumberofReturnValues()
        {
            //Arrange
            Course course1 = new Course
            {
                Capacity = 20, CourseCode = "COMP4300", CourseDesc = "Great", CourseName = "Application", CourseId = 12345
            };
            Course course2 = new Course
            {
                Capacity = 20, CourseCode = "COMP4300", CourseDesc = "Great", CourseName = "Application", CourseId = 12345
            };

            var _courses = new List<Course>();
            _courses.Add(course1);
            _courses.Add(course2);

            var _DbMock = new Mock<ApplicationDbContext>();
            if (course1 != null) _DbMock.Setup<DbSet<Course>>(x => x.Course).ReturnsDbSet(_courses);
            var _courseController = new CoursesController(_DbMock.Object);

            //Act
            var result = (await _courseController.Index());


            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Course>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }
    }
}
