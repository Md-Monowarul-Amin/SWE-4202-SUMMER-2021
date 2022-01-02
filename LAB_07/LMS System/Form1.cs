using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_LIBRARY;

namespace LMS_System
{   

    public partial class Form1 : Form
    {

        List<Professor> Professors = new List<Professor>();
        List<Lecturer> Lecturers = new List<Lecturer>();
        List<Course> Courses = new List<Course>();
        List<Student> Students = new List<Student>();
        int teacher_id = 0;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Professor");
            comboBox1.Items.Add("Lecturer");

            comboBox2.Items.Add("Lab");
            comboBox2.Items.Add("Theory");

            for(int i =1; i<=8; i++)
            {
                comboBox3.Items.Add(i.ToString());
                comboBox5.Items.Add(i.ToString());
            }

            University IUT = new University("IUT", Professors, Lecturers);

    }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            comboBox4.Items.Clear();
            if (comboBox2.Text == "Lab")
            {
                foreach(Lecturer Lecturer in Lecturers)
                {
                    comboBox4.Items.Add(Lecturer.name.ToString());
                }
            }
            else if(comboBox2.Text == "Theory")
            {
                foreach(Professor Professor in Professors)
                {
                    comboBox4.Items.Add(Professor.name.ToString());
                }
            }
        }

        private void Teacher_ADD_Click(object sender, EventArgs e)
        {
            string teacher_name = textBox1.Text;
            string teacer_type = comboBox1.Text;
            teacher_id += 1;
            comboBox8.Items.Add(teacher_name);

            if (teacer_type == "Professor")
            {
                Professor dummy_professor = new Professor(teacher_name, teacher_id);
                Professors.Add(dummy_professor);
                MessageBox.Show("Teacher Added");

            }
            else if(teacer_type== "Lecturer")
            {
                Lecturer dummy_lecturer = new Lecturer(teacher_name, teacher_id);
                Lecturers.Add(dummy_lecturer);
                MessageBox.Show("Teacher Added");
            }


        }

        private void Course_ADD_Click(object sender, EventArgs e)
        {
            string course_code = textBox2.Text;
            string course_type= comboBox2.Text;
            string course_title = textBox3.Text;
            string semister = comboBox3.Text;
            string course_teacher = comboBox4.Text;

            Course dymmy_course = new Course(course_code, course_type, course_title, semister, course_teacher);
            Courses.Add(dymmy_course);
            foreach(Lecturer lecturer in Lecturers)
            {
                if (lecturer.name == course_teacher)
                {
                    lecturer.course_code = course_code;
                    lecturer.course_title = course_title;
                    lecturer.semister = semister;
                }
            }
            foreach (Professor professor in Professors)
            {
                if (professor.name == course_teacher)
                {
                    professor.course_code = course_code;
                    professor.course_title = course_title;
                    professor.semister = semister;

                }
            }


            MessageBox.Show("Course Added");

        }

        private void STUDENT_ADD_Click(object sender, EventArgs e)
        {
            string student_name = textBox4.Text;
            comboBox7.Items.Add(student_name);
            string semister = comboBox5.Text;
            string course_title = comboBox6.Text;

            comboBox7.Items.Add(student_name);

            Student dymmy_student = new Student(student_name, semister, course_title);
            Students.Add(dymmy_student);
            MessageBox.Show("Student info. added");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semister = comboBox5.Text;
            foreach(Course course in Courses)
            {
                if (course.semister == semister)
                {
                    comboBox6.Items.Add(course.course_title);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Show_student_info_Click(object sender, EventArgs e)
        {
            string student_name = comboBox7.Text;
            listBox1.Items.Clear();
            foreach (Student student in Students)
            {
                if(student.name == student_name)
                {
                    listBox1.Items.Add("Studetnt name: " + student.name);
                    listBox1.Items.Add("Semister: " + student.semister);
                    listBox1.Items.Add("Course Title" + student.course_title);

                }
            }
        }

        private void Show_teacher_info_Click(object sender, EventArgs e)
        {   
            listBox2.Items.Clear();
            string teacher_name = comboBox8.Text;

            foreach(Professor teacher in Professors)
            {
                if( teacher.name == teacher_name)
                {
                    listBox2.Items.Add("Teacher name: " + teacher.name);
                    listBox2.Items.Add("Teacher id: " + teacher.id);
                    listBox2.Items.Add("Teacher type: " + teacher.teacher_type);
                    listBox2.Items.Add("Course_Code" + teacher.course_code);
                    listBox2.Items.Add("Course Title" + teacher.course_title);
                    listBox2.Items.Add("Semister: " + teacher.semister);
                }
            }
            foreach (Lecturer teacher in Lecturers)
            {
                if (teacher.name == teacher_name)
                {
                    listBox2.Items.Add("Teacher name: " + teacher.name);
                    listBox2.Items.Add("Teacher id: " + teacher.id);
                    listBox2.Items.Add("Teacher type: " + teacher.teacher_type);
                    listBox2.Items.Add("Course_Code" + teacher.course_code);
                    listBox2.Items.Add("Course Title" + teacher.course_title);
                    listBox2.Items.Add("Semister: " + teacher.semister);
                }
            }
        }
    }
}
