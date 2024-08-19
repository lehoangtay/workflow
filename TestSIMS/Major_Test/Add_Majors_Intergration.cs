using System;
using System.Linq;
using System.Threading.Tasks;
using Bunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using BlazorApp3.Data;
using BlazorApp3.Models;
using BlazorApp3.Components.Pages.MajorsPages;
using Microsoft.AspNetCore.Components;

namespace Testing_SIMS2
{
    public class AddMajorIntegrationTests : TestContext
    {
        public AddMajorIntegrationTests()
        {
            // Cấu hình cơ sở dữ liệu SQL Server thực tế cho kiểm thử bằng cách sử dụng chuỗi kết nối từ lớp cấu hình
            Services.AddDbContextFactory<ApplicationDbContext>(options =>
                options.UseSqlServer(DatabaseConfiguration.ConnectionString));
        }

        [Fact]
        public async Task Add_Major_Integration()
        {
            // Sắp xếp (Arrange)
            var contextFactory = Services.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();
            using var context = contextFactory.CreateDbContext();

            // Tạo một phòng ban mẫu để gắn với ngành học mới
            var department = new Departments { Name = "Engineering" };
            context.Departments.Add(department);
            await context.SaveChangesAsync();

            // Bắt đầu giao dịch
            using var transaction = await context.Database.BeginTransactionAsync();

            // Thực thi (Act)
            var cut = RenderComponent<Create>();

            // Điền thông tin vào biểu mẫu
            await cut.InvokeAsync(() => cut.Find("input#name").Change("Computer Engineering"));
            await cut.InvokeAsync(() => cut.Find("select#departmentid").Change(department.Id.ToString()));

            // Giả lập việc gửi biểu mẫu
            await cut.InvokeAsync(() => cut.Find("button[type='submit']").Click());

            // Xác nhận (Assert)
            await Task.Delay(1000); // Chờ các thao tác bất đồng bộ hoàn tất

            var major = await context.Majors
                .Where(m => m.Name == "Computer Engineering" &&
                            m.DepartmentId == department.Id)
                .FirstOrDefaultAsync();

            Assert.NotNull(major); // Kiểm tra xem ngành học đã được thêm chưa
            Assert.Equal("Computer Engineering", major.Name);
            Assert.Equal(department.Id, major.DepartmentId);

            // Hoàn tác giao dịch
            await transaction.RollbackAsync();
        }

    }
}
