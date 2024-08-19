using System;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.CoursesPages;

namespace Testing_SIMS2.Course_Test
{
    public class Add_Courses_UnitTest : TestContext
    {
        [Fact]
        public async Task AddCourse_ShouldAddCourseToDatabase()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestCourseDatabase")
                .Options;
            var dbContextFactory = new TestDbContextFactory(options);
            Services.AddSingleton<IDbContextFactory<ApplicationDbContext>>(dbContextFactory);
            // Seed data for related entities (Semesters, Subjects, Lectures)
            using var seedContext = dbContextFactory.CreateDbContext();
            var semester = new Semesters { Name = "Spring 2024" };
            var subject = new Subjects { Name = "Data Structures", Code = "CS101" };
            var lecture = new ApplicationUser
            {
                UserName = "johndoe",
                Name = "John Doe",
                Role = "Lecture",
                Code = "JD123" 
            };
            seedContext.Semesters.Add(semester);
            seedContext.Subjects.Add(subject);
            seedContext.ApplicationUser.Add(lecture);
            await seedContext.SaveChangesAsync();
            // Act
            var component = RenderComponent<Create>();
            component.Find("input#name").Change("Advanced Programming");
            component.Find("input#startdate").Change("2024-09-01");
            component.Find("input#enddate").Change("2024-12-31");
            component.Find("select#semesterid").Change(semester.Id.ToString());
            component.Find("select#lectureid").Change(lecture.Id.ToString());
            component.Find("select#subjectid").Change(subject.Id.ToString());
            component.Find("button[type='submit']").Click();
            // Assert
            using var context = dbContextFactory.CreateDbContext();
            var savedCourse = await context.Courses.FirstOrDefaultAsync(c => c.Name == "Advanced Programming");
            Assert.NotNull(savedCourse);
            Assert.Equal("Advanced Programming", savedCourse.Name);
            Assert.Equal(semester.Id, savedCourse.SemesterId);
            Assert.Equal(lecture.Id, savedCourse.LectureId);
            Assert.Equal(subject.Id, savedCourse.SubjectId);
        }
    }
    // Helper class to create DbContextFactory
    public class TestDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;
        public TestDbContextFactory(DbContextOptions<ApplicationDbContext> options)
        {
            _options = options;
        }

        public ApplicationDbContext CreateDbContext()
        {
            return new ApplicationDbContext(_options);
        }
    }
}
