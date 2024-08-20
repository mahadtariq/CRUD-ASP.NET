using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class StudentDAL
    {

        //StudentModel model = new StudentModel
        //{   Id = 1,
        //    Name = "Alice",
        //    Report = "Excellent progress",
        //    Grade = 'A',
        //    Marks = 95,
        //    Gender = 'F' };

        public static List<StudentModel> studentList = new List<StudentModel>
        {
                new StudentModel { Id = 1, Name = "Mahad", Report = "Excellent progress", Grade = 'A', Marks = 95, Gender = 'M' },
                new StudentModel { Id = 2, Name = "Abdullah", Report = "Good performance", Grade = 'B', Marks = 85, Gender = 'M' },
                new StudentModel { Id = 3, Name = "Mustafa", Report = "Needs improvement", Grade = 'C', Marks = 70, Gender = 'M' },
                new StudentModel { Id = 4, Name = "Ali", Report = "Outstanding", Grade = 'A', Marks = 98, Gender = 'F' },
                new StudentModel { Id = 5, Name = "Alina", Report = "Satisfactory", Grade = 'B', Marks = 80, Gender = 'F' },
                new StudentModel { Id = 6, Name = "Tipu", Report = "Average", Grade = 'C', Marks = 65, Gender = 'M' },
                new StudentModel { Id = 7, Name = "Ayesha", Report = "Excellent progress", Grade = 'A', Marks = 92, Gender = 'F' },
                new StudentModel { Id = 8, Name = "Ashraf", Report = "Below average", Grade = 'D', Marks = 55, Gender = 'M' },
                new StudentModel { Id = 9, Name = "Katrina", Report = "Good performance", Grade = 'B', Marks = 88, Gender = 'F' },
                new StudentModel { Id = 10, Name = "Raja", Report = "Needs improvement", Grade = 'C', Marks = 68, Gender = 'M' }
            };

        public static List<StudentModel> ShowStudent()
        {
            return studentList;
        }

        public static void saveData(StudentModel student)
        {
            studentList.Add(student);
        }

        public static bool FindDelete(int id)
        {
             var deleteStudent= studentList.Find(x => x.Id == id);

            if (deleteStudent != null)
            {
                studentList.Remove(deleteStudent);
                return true;
            }
            return false;
        }

        public static bool updateStudent(int id, StudentModel student)
        {
            var existingUser = studentList.Find(x => x.Id == id);
            if (existingUser != null)
            {
                existingUser.Id = student.Id;
                existingUser.Name = student.Name;
                existingUser.Report = student.Report;
                existingUser.Grade = student.Grade;
                existingUser.Marks = student.Marks;
                existingUser.Gender = student.Gender;

                return true;
            }
            return false;
        }

    }
}
