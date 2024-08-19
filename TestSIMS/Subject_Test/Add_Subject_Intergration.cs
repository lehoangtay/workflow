using System;
using System.Linq;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.SubjectsPages;
using Microsoft.AspNetCore.Components;

namespace Testing_SIMS2
{
    public class AddSubjectIntegrationTests : TestContext
    {
        public AddSubjectIntegrationTests()
        {
            // Setup real SQL Server database for testing using the connection string from the configuration class
            Services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(DatabaseConfiguration.ConnectionString));
        }

        [Fact]
        public async Task Add_Subject_Integration()
        {
            // Arrange
            var contextFactory = Services.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();
            using var context = contextFactory.CreateDbContext();
            // Start a transaction
            using var transaction = await context.Database.BeginTransactionAsync();

            // Act
            var cut = RenderComponent<Create>();
            // Fill in the form using InvokeAsync to ensure DOM stability
            await cut.InvokeAsync(() => cut.Find("input#name").Change("Data Structures"));
            await cut.InvokeAsync(() => cut.Find("select#majorid").Change("1"));
            await cut.InvokeAsync(() => cut.Find("input#code").Change("CS102"));
            // Simulate form submission
            await cut.InvokeAsync(() => cut.Find("button[type='submit']").Click());
            // Assert
            await Task.Delay(1000); 
            var subject = await context.Subjects
                .Where(s => s.Name == "Data Structures" &&
                            s.Code == "CS102" &&
                            s.MajorId == 1)
                .FirstOrDefaultAsync();
            Assert.NotNull(subject);
            Assert.Equal("Data Structures", subject.Name);
            Assert.Equal("CS102", subject.Code);
            Assert.Equal(1, subject.MajorId); 
            await transaction.RollbackAsync();
        }

    }
}
