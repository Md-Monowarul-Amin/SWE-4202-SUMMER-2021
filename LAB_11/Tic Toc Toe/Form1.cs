using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("X");
            comboBox1.Items.Add("O");
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string player_sign = comboBox1.Text;
            string computer_sign;
            button1.Text = player_sign;
            if (button1.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }
            
            if(button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button2.Text = player_sign;
            if (button1.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button3.Text = player_sign;
            if (button3.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button6.Text = player_sign;
            if (button6.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button5.Text = player_sign;
            if (button5.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button4.Text = player_sign;
            if (button4.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button9.Text = player_sign;
            if (button9.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button8.Text = player_sign;
            if (button8.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button7.Text == "!")
            {
                button7.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string player_sign = comboBox1.Text;
            string computer_sign;
            button7.Text = player_sign;
            if (button7.Text == "X")
            {
                computer_sign = "O";
            }
            else
            {
                computer_sign = "X";
            }

            if (button2.Text == "!")
            {
                button2.Text = computer_sign;
            }
            else if (button3.Text == "!")
            {
                button3.Text = computer_sign;
            }
            else if (button4.Text == "!")
            {
                button4.Text = computer_sign;
            }
            else if (button5.Text == "!")
            {
                button5.Text = computer_sign;
            }
            else if (button6.Text == "!")
            {
                button6.Text = computer_sign;
            }
            else if (button1.Text == "!")
            {
                button1.Text = computer_sign;
            }
            else if (button8.Text == "!")
            {
                button8.Text = computer_sign;
            }
            else if (button9.Text == "!")
            {
                button9.Text = computer_sign;
            }
        }
    }
}
