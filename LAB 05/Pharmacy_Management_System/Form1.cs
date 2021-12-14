using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHARMACY_MANAGEMENT_LIBRARY;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        int balance = 0;
        List<medicine> medicine_list = new List<medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ADD_MED_Click(object sender, EventArgs e)
        {
            string med_name = textBox1.Text;
            int med_qty = int.Parse(textBox2.Text);
            string med_company = textBox4.Text;
            string exp_date = textBox3.Text;
            int unit_price = int.Parse(textBox5.Text);

            medicine new_medicine = new medicine();
            new_medicine.med_name = med_name;
            new_medicine.med_qty = med_qty;
            new_medicine.med_company = med_company;
            new_medicine.med_exp = exp_date;
            new_medicine.price = unit_price;
            medicine_list.Add(new_medicine);
            MessageBox.Show("Medicine Added");
            med_cmb_bx.Items.Add(med_name);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void availailability_Click(object sender, EventArgs e)
        {
            string med_name = textBox7.Text;
            foreach(medicine med in medicine_list)
            {
                if (med.med_name == med_name)
                {
                    label7.Text = "QTY" + med.med_qty.ToString();
                    label9.Text = "UNIT_PRICE" + med.price.ToString();
                    label10.Text = "EXP" + med.med_exp;
                }
            }
            
        }

        private void SEll_click(object sender, EventArgs e)
        {
            string med_name = med_cmb_bx.Text;
            int med_qty = int.Parse(textBox8.Text);
            foreach(medicine med in medicine_list)
            {
                if(med.med_name == med_name)
                {   
                    if (med.med_qty < med_qty)
                    {
                        MessageBox.Show("Out of range");
                    }
                    else
                    {
                        int total_price = med.price * med_qty;
                        balance = balance + total_price;
                        med.med_qty = med.med_qty - med_qty;
                        MessageBox.Show("Medicine Sold" + " Bill:" + total_price);
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            label12.Text = balance.ToString() + "$";
        }
    }
}
