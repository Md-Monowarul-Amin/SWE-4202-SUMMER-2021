using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_2_Educational_Institution_Library;

namespace Task_2_Educational_Institution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Teacher new_teacher = new Teacher("Sir", "1", "Math", "Journal_1");
            string id_new = new_teacher.id;
            Console.WriteLine(id_new);
            new_teacher.Who_Am_I(id_new);
        }
    }
}
