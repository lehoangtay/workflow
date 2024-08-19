using System;
using System.Linq;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.DepartmentsPages;
using Microsoft.AspNetCore.Components;

namespace Testing_SIMS2
{
    public class AddDepartmentIntegrationTests : TestContext
    {
        public AddDepartmentIntegrationTests()
        {
            Services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(DatabaseConfiguration.ConnectionString));
        }

        [Fact]
        public async Task Add_Department_Integration()
        {
            // Arrange
            var contextFactory = Services.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();
            using var context = contextFactory.CreateDbContext();
            using var transaction = await context.Database.BeginTransactionAsync();
            // Act
            var cut = RenderComponent<Create>();
            cut.Find("input#name").Change("Computer Science");
            cut.Find("button[type='submit']").Click();
            // Assert
            await Task.Delay(1000);
            var department = await context.Departments
                .Where(d => d.Name == "Computer Science")
                .FirstOrDefaultAsync();
            Assert.NotNull(department); 
            Assert.Equal("Computer Science", department.Name);
            await transaction.RollbackAsync();
        }
    }
}
