using System;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.SubjectsPages; 
using Microsoft.AspNetCore.Components;


namespace TestSIMS2_Subject_Test
{
    public class Delete_Subject_UnitTest : TestContext
    {
        [Fact]
        public async Task DeleteSubject_ShouldRemoveSubjectFromDatabase()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;
            var dbContextFactory = new TestDbContextFactory(options);
            using (var context = dbContextFactory.CreateDbContext())
            {
                var major = new Majors
                {
                    Id = 1,
                    Name = "Science",
                    DepartmentId = 1 
                };
                context.Majors.Add(major);
                await context.SaveChangesAsync();
                var subject = new Subjects
                {
                    Id = 1,
                    Name = "Mathematics",
                    Code = "MATH101",
                    MajorId = major.Id, 
                    Major = major 
                };
                context.Subjects.Add(subject);
                await context.SaveChangesAsync();
            }
            Services.AddSingleton<IDbContextFactory<ApplicationDbContext>>(dbContextFactory);
            var navigationManager = Services.GetRequiredService<NavigationManager>();
            var uri = navigationManager.GetUriWithQueryParameter("Id", "1");
            navigationManager.NavigateTo(uri);
            var component = RenderComponent<Delete>();
            // Act
            component.Find("button").Click();
            // Assert
            using (var context = dbContextFactory.CreateDbContext())
            {
                var deletedSubject = await context.Subjects.FirstOrDefaultAsync(s => s.Id == 1);
                Assert.Null(deletedSubject); 
            }
        }
    }
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
