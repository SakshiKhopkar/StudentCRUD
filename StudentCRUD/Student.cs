using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Per { get; set; }
        public string Dept { get; set; }
    }
    public class Getstudent
    {
        private List<Student> studentlist;
        public Getstudent()
        {
            studentlist = new List<Student>()
            {
              new Student{RollNo = 1,Name="Sahil",Per=90.0,Dept="Mech"},
              new Student{RollNo = 2,Name="Sandhya",Per=87.9,Dept="ENTC"},
              new Student{RollNo = 3,Name="Snehal",Per=68.9,Dept="Civil"}
            };
        }
        public List<Student> StudentList()
        {
         return studentlist;
        }

        public Student GetStudentbyRollNo(int rollno)
        { Student student = new Student();
            foreach( Student s in studentlist)
            {
                if(s.RollNo == rollno)
                {
                    student = s;
                }
            }
         return student;
        }
        public void AddStudent(Student s)
        {
          studentlist.Add(s);
        }
        public void UpdateStudent(Student p)
        {
            foreach( Student s in studentlist)
            {
                if(s.RollNo==p.RollNo)
                {
                    
                    s.Name = p.Name;
                    s.Per = p.Per;
                    s.Dept = p.Dept;
                    break;
                }
            }
            Console.WriteLine(" student saved.....");
        }
        public void DeleteStudent(int rollno)
        {
          foreach(Student s in studentlist)
            {
                if (s.RollNo == rollno)
                {
                    studentlist.Remove(s);
                    break;
                }
            }
        }
    }
}
