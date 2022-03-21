using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mid.Text = textBox5.Text;
            Final.Text = textBox6.Text;
            string quiz_1 = textBox7.Text;
            string quiz_2 = textBox8.Text;
            string quiz_3 = textBox9.Text;
            string quiz_4 = textBox10.Text;
            double quiz_1_num = Convert.ToDouble(quiz_1);
            double quiz_2_num = Convert.ToDouble(quiz_2);
            double quiz_3_num = Convert.ToDouble(quiz_3);
            double quiz_4_num = Convert.ToDouble(quiz_4);

            double quiz_total = quiz_1_num + quiz_2_num + quiz_3_num + quiz_4_num;
            
            Quiz.Text = quiz_total.ToString();

            string attendance = textBox4.Text;
            string mid_mark = textBox5.Text;
            string final_mark = textBox6.Text;
            double attendance_int = Convert.ToDouble(attendance);
            double attendance_mark = (attendance_int / 28) * 30;
            double mid_mark_int = Convert.ToDouble(mid_mark);
            double final_mark_int = Convert.ToDouble (final_mark);
            double total_mark_int = attendance_mark + mid_mark_int + final_mark_int + quiz_total;

            if (total_mark_int >= 80)
            {
                GRADE.Text = "A+";
            }
            else if (total_mark_int > 75)
            {
                GRADE.Text = "A";
            } 
            else if(total_mark_int > 70)
            {
                GRADE.Text= "A-";
            }
            else if(total_mark_int > 65)
            {
                GRADE.Text = "B+";  
            }
            else if(total_mark_int > 60)
            {
                GRADE.Text = "B-";
            }
            else if(total_mark_int > 50)
            {
                GRADE.Text = "C";
            }
            else if(total_mark_int > 40)
            {
                GRADE.Text = "D";
            }
            else if(total_mark_int > 0)
            {
                GRADE.Text = "F";
            }
            
            double percentage = (total_mark_int / 300) * 100;
            string percentage_str = percentage.ToString();
            Total.Text = total_mark_int.ToString();
            string Name = textBox1.Text;
            string list = Name + " Obtained " + percentage_str + " % " + " Marks ";
            COMMENT.Text = list;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
