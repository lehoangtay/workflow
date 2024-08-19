using System;
using System.Linq;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.CoursesPages;
using Microsoft.AspNetCore.Components;

namespace Testing_SIMS2
{
    public class AddCoursesIntegrationTests : TestContext
    {
        public AddCoursesIntegrationTests()
        {
            // Setup real SQL Server database for testing using the connection string from the configuration class
            Services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(DatabaseConfiguration.ConnectionString));
        }
        [Fact]
        public async Task Add_Courses_Integration()
        {
            var contextFactory = Services.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();
            using var context = contextFactory.CreateDbContext();

            // Ensure required data exists for the test
            if (!await context.ApplicationUser.AnyAsync(u => u.Id == "user123"))
            {
                context.ApplicationUser.Add(new ApplicationUser
                {
                    Id = "user123",
                    UserName = "user123",
                    Name = "Dr. Smith",
                    Code = "USER123",
                    Role = "Professor"
                });
                await context.SaveChangesAsync();
            }

            if (!await context.Semesters.AnyAsync(s => s.Id == 1))
            {
                context.Semesters.Add(new Semesters
                {
                    Id = 1,
                    Name = "Fall 2024",
                    StartDate = new DateTime(2024, 9, 1),
                    EndDate = new DateTime(2024, 12, 15)
                });
                await context.SaveChangesAsync();
            }

            if (!await context.Subjects.AnyAsync(s => s.Name == "Introduction to Programming"))
            {
                context.Subjects.Add(new Subjects
                {
                    Name = "Introduction to Programming",
                    Code = "PROG101",
                    MajorId = 1
                });
                await context.SaveChangesAsync();
            }
            // Act
            var cut = RenderComponent<Create>();
            await cut.InvokeAsync(() => cut.Find("input#name").Change("Software Engineering"));
            await cut.InvokeAsync(() => cut.Find("input#startdate").Change("2024-09-01"));
            await cut.InvokeAsync(() => cut.Find("input#enddate").Change("2024-12-15"));
            await cut.InvokeAsync(() => cut.Find("select#semesterid").Change("1"));
            await cut.InvokeAsync(() => cut.Find("select#lectureid").Change("user123"));
            await cut.InvokeAsync(() => cut.Find("select#subjectid").Change("1"));
            await cut.InvokeAsync(() => cut.Find("button[type='submit']").Click());
            // Add a delay to ensure async operations complete
            await Task.Delay(1000);
            // Assert
            var course = await context.Courses
                .Where(c => c.Name == "Software Engineering" &&
                            c.StartDate == new DateTime(2024, 9, 1) &&
                            c.EndDate == new DateTime(2024, 12, 15) &&
                            c.SemesterId == 1 &&
                            c.LectureId == "user123" &&
                            c.SubjectId == 1)
                .FirstOrDefaultAsync();
            if (course == null)
            {
                // Log more details if the value is null
                var courses = await context.Courses.ToListAsync();
                Console.WriteLine($"Courses in the database: {string.Join(", ", courses.Select(c => c.Name))}");
                var semesters = await context.Semesters.ToListAsync();
                Console.WriteLine($"Semesters in the database: {string.Join(", ", semesters.Select(s => s.Name))}");
                var subjects = await context.Subjects.ToListAsync();
                Console.WriteLine($"Subjects in the database: {string.Join(", ", subjects.Select(s => s.Name))}");
                throw new Exception("Course could not be found in the database.");
            }

            Assert.NotNull(course); // Ensure course is not null
            Assert.Equal("Software Engineering", course.Name);
            Assert.Equal(new DateTime(2024, 9, 1), course.StartDate);
            Assert.Equal(new DateTime(2024, 12, 15), course.EndDate);
            Assert.Equal(1, course.SemesterId);
            Assert.Equal("user123", course.LectureId);
            Assert.Equal(1, course.SubjectId);
        }

    }
}
