using BlazorApps1.Data;

namespace BlazorApps1.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SemesterId { get; set; }
        public int SubjectId { get; set; }
        public String LectureId { get; set; }
        public Semesters Semester { get; set; }
        public Subjects Subject { get; set; }
        public ApplicationUser Lecture { get; set; }
    }
}
