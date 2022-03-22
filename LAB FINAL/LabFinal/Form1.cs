using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LabFinalLibrary;

namespace LabFinal
{
    public partial class Form1 : Form
    {   
        List<Student> student_list = new List<Student>();
        private object reader;

        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\USER\Desktop\LAB_OOC_1\LabFinal\SWE4201MarkSheet_NEW.csv"))

            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);

                }

                string output_string_2 = "";

                foreach (string str in listA)
                {

                    string[] str_sep = str.Split(',');
                    string id = str_sep[0];
                    string name = str_sep[1];
                    string attendance_str = str_sep[2];
                    int attendance = Convert.ToInt32(attendance_str);
                    int quiz_1_mark;
                    int quiz_2_mark;
                    int quiz_3_mark;
                    int quiz_4_mark;
                    int mid_mark;
                    int final_mark;
                    int viva_mark;
                    if(str_sep[3] == null)
                    {
                        quiz_1_mark = 0;
                    }
                    else
                    {
                        quiz_1_mark = Convert.ToInt32(str_sep[3]);
                    }
                    
                    if(str_sep[4] == null)
                    {
                        quiz_2_mark = 0;
                    }
                    else
                    {
                        quiz_2_mark = Convert.ToInt32(str_sep[4]);
                    }
                    
                    if(str_sep[5] == null)
                    {
                        quiz_3_mark = 0;
                    }
                    else
                    {
                        quiz_3_mark = Convert.ToInt32(str_sep[5]);
                    }
                    
                    if(str_sep[6] == null)
                    {
                        quiz_4_mark = 0;
                    }
                    else
                    {
                        quiz_4_mark = Convert.ToInt32(str_sep[6]);
                    }

                    if (str_sep[7] == null)
                    {
                        mid_mark = 0;
                    }
                    else
                    {
                        mid_mark = Convert.ToInt32(str_sep[7]);
                    }
                    if(str_sep[8] == null)
                    {
                        final_mark = 0;
                    }
                    else
                    {
                        final_mark = Convert.ToInt32(str_sep[8]);
                    }
                    if(str_sep[9] == null)
                    {
                        viva_mark = 0;
                    }
                    else
                    {
                        viva_mark = Convert.ToInt32(str_sep[9]);
                    }
                    

                    Student dummy_student = new Student(id, name, attendance, quiz_1_mark, quiz_2_mark, quiz_3_mark, quiz_4_mark, mid_mark, final_mark, viva_mark);
                    student_list.Add(dummy_student);
                    int total = dummy_student.total;
                    
                    
                    float percent = total / 3;
                    dummy_student.percentage = percent;
                    string grade = dummy_student.count_grade();

                    output_string_2 += str_sep[0] + " " + str_sep[1] + " " + percent.ToString() + "%" + grade;
                    listBox1.Items.Add(output_string_2);
                    output_string_2 = "";
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            foreach(Student student in student_list)
            {
                if(student.Id == id)
                {
                    label26.Text = student.attendance_mark.ToString();
                    label24.Text = student.quiz_1_mark.ToString();
                    label22.Text = student.quiz_2_mark.ToString();
                    label21.Text = student.quiz_3_mark.ToString();
                    label23.Text = student.quiz_4_mark.ToString();
                 
                    label20.Text = student.mid_mark.ToString();
                    label19.Text = student.final_mark.ToString();
                    label18.Text = student.viva_mark.ToString();
                    label17.Text = student.total.ToString();
                    label17.Text = student.percentage.ToString() + "%";
                    label16.Text = student.grade.ToString();
                    label27.Text = student.total.ToString();

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
