using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinalLibrary
{
    public class Student
    {
        public string Id;
        public string Name { get; set; }
        public int attendance_mark = 0;
        public int quiz_1_mark = 0;
        public int quiz_2_mark = 0;
        public int quiz_3_mark = 0;
        public int quiz_4_mark = 0;
        public int quiz_total = 0;
        public int mid_mark = 0;
        public int final_mark = 0;
        public int viva_mark = 0;
        public int total = 0;
        public float percentage = 0;
        public string grade = "F";


        public Student(string id, string name, int attendance_mark, int quiz_1_mark, int quiz_2_mark, int quiz_3_mark, int quiz_4_mark, int mid_mark, int final_mark, int viva_mark)
        {
            this.Id = id;
            this.Name = name;
            this.quiz_1_mark = quiz_1_mark;
            this.quiz_2_mark = quiz_2_mark;
            this.quiz_3_mark = quiz_3_mark;
            this.quiz_4_mark = quiz_4_mark;
            this.attendance_mark = attendance_mark;
            this.quiz_total = quiz_1_mark + quiz_2_mark + quiz_3_mark + quiz_4_mark;
            this.final_mark = final_mark;
            this.mid_mark = mid_mark;
            this.viva_mark = viva_mark;
            this.total = quiz_total + mid_mark + final_mark + viva_mark + attendance_mark;
            float percentage_ff = (this.total / 300) * 100;
            this.percentage = percentage_ff;
        }
        public string count_grade()
        {

            

            if (this.percentage >= 80 && this.percentage <= 100)
            {
                this.grade = "A+";
            }
            else if (this.percentage >= 75 && this.percentage <= 79)
            {
                this.grade = "A";
            }
            else if (this.percentage >= 70 && this.percentage <= 74)
            {
                this.grade = "A-";
            }
            else if (this.percentage >= 65 && this.percentage <= 69)
            {
                this.grade = "B+";
            }
            else if (this.percentage >= 60 && this.percentage <= 64)
            {
                this.grade = "B";
            }
            else if (this.percentage >= 55 && this.percentage <= 59)
            {
                this.grade = "B-";
            }
            else if (this.percentage >= 50 && this.percentage <= 54)
            {
                this.grade = "C+";
            }
            else if (this.percentage >= 45 && this.percentage <= 49)
            {
                this.grade = "C";
            }
            else if (this.percentage >= 40 && this.percentage <= 44)
            {
                this.grade = "D";
            }
            else if (this.percentage >= 0 && this.percentage <= 39)
            {
                this.grade = "F";
            }

            else
            {
                this.grade = "Unknown Grade";
            }

            return this.grade;

        }

    }
}
