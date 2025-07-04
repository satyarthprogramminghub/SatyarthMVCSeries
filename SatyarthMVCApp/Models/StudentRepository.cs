﻿namespace SatyarthMVCApp.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> DataSource() =>
     new()
     {
            new Student { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
            new Student { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
            new Student { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
            new Student { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
            new Student { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" },
     };
        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(s => s.StudentId == StudentId) ?? new Student();
        }
    }
}
