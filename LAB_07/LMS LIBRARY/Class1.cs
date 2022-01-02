using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_LIBRARY
{   

    public class University
    {
        public string name;
        public List<Professor> Professor_list;
        public List<Lecturer> Lecturer_list;

        public University(string name,List<Professor> Professor_list, List<Lecturer> Lecturer_list)
        {
            this.name = name;
            this.Professor_list = Professor_list;
            this.Lecturer_list = Lecturer_list;
        }

        
    }

    public abstract class Teacher
    {
        public string teacher_type = "";
        public string name;
        public int id;
        public string course_title;
        public string course_code;
        public string semister;

    }

    public class Lecturer : Teacher
    {
        

        public Lecturer(string name, int teacher_id)
        {
            this.name = name;
            this.teacher_type = "Lecturer";
            this.id = teacher_id;
        }

    }

    public class Professor : Teacher
    {
       
        public Professor(string name, int teacher_id)
        {
            this.name = name;
            this.teacher_type = "Professor";
            this.id=teacher_id;

        }

    }

    public class Course
    {
        public string course_code;
        public string course_type;
        public string course_title;
        public string semister;
        public string course_teacher;

        public Course(string course_code, string course_type, string course_title, string semister, string course_teacher)
        {
            this.course_code = course_code; 
            this.course_type = course_type; 
            this.course_title = course_title;
            this.semister = semister;
            this.course_teacher = course_teacher;

        }

    }

    public class Student
    {
        public string name;
        public string semister;
        public string course_title;

        public Student(string name, string semister, string course_title)
        {
            this.name=name;
            this.semister=semister;
            this.course_title=course_title;
        }
    }
}
