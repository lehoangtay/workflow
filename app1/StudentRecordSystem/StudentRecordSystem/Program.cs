using System;
using StudentRecordSystem;

class Program
{
    static void Main(string[] args)
    {
        // Vòng lặp vô hạn cho menu
        while (true)
        {
            // Hiển thị các tùy chọn cho người dùng
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1: Add Student");
            Console.WriteLine("2: Count Students");
            Console.WriteLine("3: find an item by title or author");
            Console.WriteLine("0: Exit");

            // Chuyển đổi lựa chọn của người dùng từ chuỗi thành số nguyên
            int feature = Convert.ToInt32(Console.ReadLine());

            // Nếu người dùng chọn 0, thoát khỏi vòng lặp và kết thúc chương trình
            if (feature == 0)
            {
                break;
            }
            else if (feature == 1)
            {
                // Người dùng chọn thêm sinh viên
                Console.WriteLine("Enter FirstName of the student:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter LastName of the student:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Student ID:");
                string studentId = Console.ReadLine();
                Console.WriteLine("Please enter Date of Birth (YYYY-MM-DD) or leave empty:");
                string dateBirthInput = Console.ReadLine();
                DateTime? dateBirth = null;
                // Kiểm tra nếu ngày sinh không trống và chuyển đổi thành DateTime
                if (!string.IsNullOrEmpty(dateBirthInput) && DateTime.TryParse(dateBirthInput, out DateTime parsedDate))
                {
                    dateBirth = parsedDate;
                }
                // Tạo một đối tượng Student mới
                Student newStudent = new Student(firstName, lastName, studentId, dateBirth);
                newStudent.SetEnrollmentDate(null); // Thiết lập ngày nhập học mặc định
                Console.WriteLine("Student added successfully.");
                newStudent.DisplayInfo(); // Hiển thị thông tin sinh viên mới
            }
            else if (feature == 2)
            {
                // Người dùng chọn đếm số lượng sinh viên
                Console.WriteLine($"Total number of students: {Student.TotalStudents}");
            }
            else
            {
                // Người dùng chọn tùy chọn không hợp lệ
                Console.WriteLine("Invalid option, please try again.");
            }
            Console.WriteLine(); // In một dòng trống để ngăn cách giữa các lần lặp
        }

    }
}
