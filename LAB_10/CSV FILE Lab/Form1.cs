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

namespace CSV_FILE_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\USER\Desktop\LAB_OOC_1\CSV FILE Lab\userinfo.csv"))
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
                    output_string_2 += str_sep[0] + " " + str_sep[1]+ " " + str_sep[9];
                    listBox2.Items.Add(output_string_2);
                    output_string_2 = "";
                }

                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            
            string given_email = textBox1.Text;
            string time = DateTime.Now.ToString("h:mm:ss:tt");
            using (var reader = new StreamReader(@"C:\Users\USER\Desktop\LAB_OOC_1\CSV FILE Lab\userinfo.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    
                }
                int ok = 0;
                string output_string = "";
                output_string = output_string+ "  " + given_email + "  " + time;
                foreach (string str in listA)
                {
                    
                    string[] str_sep = str.Split(',');
                    string email = str_sep[9];
                    if (email == given_email)
                    {   
                        ok = 1;
                        for (int i = 0; i < 10; i++)
                        {
                            output_string = output_string + "  " + str_sep[i];
                        }
                    }
                }   
                if(ok == 0)
                {
                    output_string = "Not FOund";
                }

                listBox1.Items.Add(output_string);
            }
        }
    }
}
