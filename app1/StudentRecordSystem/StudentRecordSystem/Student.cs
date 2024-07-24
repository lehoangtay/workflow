using System;

namespace StudentRecordSystem
{
    internal class Student
    {
        // Thuộc tính (Properties)
        private DateOnly? DateBirth { get; set; } = null;  // Thuộc tính ngày sinh có thể null, khởi tạo giá trị mặc định là null
        private DateOnly? EnrollmentDate { get; set; } = null;  // Thuộc tính ngày nhập học có thể null, khởi tạo giá trị mặc định là null
        public string FirstName { get; private set; }  // Thuộc tính tên riêng, chỉ có thể được thiết lập từ bên trong lớp này
        public string LastName { get; private set; }  // Thuộc tính họ, chỉ có thể được thiết lập từ bên trong lớp này
        public string StudentID { get; private set; }  // Thuộc tính mã số sinh viên, chỉ có thể được thiết lập từ bên trong lớp này
        // Thuộc tính tĩnh để theo dõi tổng số sinh viên được tạo
        public static int TotalStudents { get; private set; } = 0;  // Thuộc tính tĩnh để lưu số lượng sinh viên, khởi tạo giá trị mặc định là 0
        // Constructor mặc định
        public Student()
        {
            FirstName = "DefaultFirstName";  // Gán giá trị mặc định cho thuộc tính FirstName
            LastName = "DefaultLastName";  // Gán giá trị mặc định cho thuộc tính LastName
            StudentID = "0000";  // Gán giá trị mặc định cho thuộc tính StudentID
            IncrementStudentCount();  // Gọi phương thức tăng số lượng sinh viên
        }
        // Constructor có tham số
        public Student(string firstName, string lastName, string studentID, DateTime? dateBirth)
        {
            FirstName = firstName;  // Gán giá trị cho thuộc tính FirstName từ tham số
            LastName = lastName;  // Gán giá trị cho thuộc tính LastName từ tham số
            StudentID = studentID;  // Gán giá trị cho thuộc tính StudentID từ tham số
            DateBirth = dateBirth.HasValue ? DateOnly.FromDateTime(dateBirth.Value) : null;  // Chuyển đổi từ DateTime sang DateOnly nếu có giá trị, ngược lại gán null
            IncrementStudentCount();  // Gọi phương thức tăng số lượng sinh viên
        }
        // Phương thức tăng số lượng sinh viên
        private void IncrementStudentCount()
        {
            TotalStudents++;  // Tăng giá trị của thuộc tính tĩnh TotalStudents lên 1
        }
        // Phương thức thiết lập ngày nhập học
        public void SetEnrollmentDate(DateOnly? enrollmentDate)
        {
            if (enrollmentDate == null)
            {
                DateTime now = DateTime.Now;  // Lấy thời gian hiện tại
                EnrollmentDate = new DateOnly(now.Year, now.Month, now.Day);  // Thiết lập ngày nhập học là ngày hiện tại
            }
            else
            {
                EnrollmentDate = enrollmentDate;  // Gán giá trị tham số cho thuộc tính EnrollmentDate
            }
        }
        // Phương thức lấy ngày nhập học
        public DateOnly? GetEnrollmentDate()
        {
            return EnrollmentDate;  // Trả về giá trị của thuộc tính EnrollmentDate
        }
        // Phương thức hiển thị thông tin sinh viên
        public void DisplayInfo()
        {
            Console.WriteLine("Student Information:");  // Hiển thị tiêu đề thông tin sinh viên
            Console.WriteLine($"StudentID: {StudentID}");  // Hiển thị mã số sinh viên
            Console.WriteLine($"FirstName: {FirstName}");  // Hiển thị tên riêng của sinh viên
            Console.WriteLine($"LastName: {LastName}");  // Hiển thị họ của sinh viên
            Console.WriteLine($"DateOfBirth: {(DateBirth.HasValue ? DateBirth.Value.ToString("yyyy-MM-dd") : "null")}");  // Hiển thị ngày sinh hoặc "null" nếu không có giá trị
            Console.WriteLine($"EnrollmentDate: {(EnrollmentDate.HasValue ? EnrollmentDate.Value.ToString("yyyy-MM-dd") : "null")}");  // Hiển thị ngày nhập học hoặc "null" nếu không có giá trị
            Console.WriteLine();  // In một dòng trống để ngăn cách
        }
    }
}
