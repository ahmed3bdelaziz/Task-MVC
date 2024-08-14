using System.Collections.Generic;

namespace MvcTask.Models
{
    public class MockStudentData
    {
        public List<Student> Students;

        public MockStudentData()
        {
            Students = new List<Student>();
            Students.Add(new Student { Id = 1, Name = "Student 1", Img = "1.jpg", Address = "860 Fake Street, City-38" });
            Students.Add(new Student { Id = 2, Name = "Student 2", Img = "2.jpg", Address = "519 Fake Street, City-23" });
            Students.Add(new Student { Id = 3, Name = "Student 3", Img = "3.jpg", Address = "262 Fake Street, City-6" });
            Students.Add(new Student { Id = 4, Name = "Student 4", Img = "4.jpg", Address = "547 Fake Street, City-43" });
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public Student GetStudentById(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public void AddStudent(int SId, string SName, string SImg, string SAddress)
        {
            Students.Add(new Student { Id = SId, Name = SName, Img = SImg, Address = SAddress });
        }
    }
}
