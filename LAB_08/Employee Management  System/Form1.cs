using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Library;

namespace Employee_Management__System
{
    public partial class Form1 : Form
    {
        int manager_id = 1;
        int sales_person_id = 1;
        int type_writer_id = 1;
        List<Manager> manager_list = new List<Manager>();
        List<Sales_Person> sales_person_list = new List<Sales_Person>();
        List<Type_Writer> type_writer_list = new List<Type_Writer>();
        List<string> id_list = new List<string>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Sales_Person");
            comboBox1.Items.Add("Type_Writer");

            comboBox2.Items.Add("Manager");
            comboBox2.Items.Add("Sales_Person");
            comboBox2.Items.Add("Type_Writer");
        }

        private void Create_Employee_Click(object sender, EventArgs e)
        {
            string emp_type = comboBox1.Text;
            string emp_name = textBox1.Text;
            string contact = textBox3.Text;
            int joining_date = Convert.ToInt32(textBox2.Text);
 
            if (emp_type == "Manager")
            {   
                string mn_id = manager_id.ToString();
                Manager dymmy_manager = new Manager(emp_name, mn_id, contact, joining_date);
                manager_list.Add(dymmy_manager);
                MessageBox.Show(emp_type + "Created");
                manager_id += 1;
            }
            else if(emp_type == "Sales_Person")
            {
                string sl_id = sales_person_id.ToString();
                Sales_Person dymmy_sales = new Sales_Person(emp_name, sl_id, contact, joining_date);
                sales_person_list.Add(dymmy_sales);
                MessageBox.Show(emp_type + "Created");
                sales_person_id += 1;
            }
            else if (emp_type == "Type_Writer")
            {
                string tr_id = type_writer_id.ToString();
                Type_Writer dymmy_writer = new Type_Writer(emp_name, tr_id, contact, joining_date);
                type_writer_list.Add(dymmy_writer);
                MessageBox.Show(emp_type + "Created");
                type_writer_id += 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowEmlpyeeInfo_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();
            string type = comboBox2.Text;
            string id = comboBox3.Text;
            bool ok = false;
            foreach (string s in id_list)
            {
                if (s == comboBox3.Text)
                {
                    ok = true; break;
                }
            }
            if (!ok)
            {
                Not_Fount_Exception ex = new Not_Fount_Exception();
                MessageBox.Show(ex.Message);
            }

            int current_date = Convert.ToInt32(textBox4.Text);
            if(type == "Manager")
            {
                
                foreach (Manager manager in manager_list)
                {
                    if (manager.id == id)
                    {   
                        int salary = manager.set_salary(current_date);

                        listBox1.Items.Add(manager.Name);
                        listBox1.Items.Add(manager.id);
                        listBox1.Items.Add(manager.contact);
                        listBox1.Items.Add(manager.current_salary);
                    }
                }
            }
            else if(type == "Sales_Person")
            {
                
                foreach (Sales_Person sales in sales_person_list)
                {
                    if (sales.id == id)
                    {
                        int salary = sales.set_salary(current_date);

                        listBox1.Items.Add("Name" + sales.Name);
                        listBox1.Items.Add("ID" + sales.id);
                        listBox1.Items.Add("contact" + sales.contact);
                        listBox1.Items.Add("Salary" + sales.current_salary);
                    }
                }
            }
            else if (type == "Type_Writer")
            {
                
                foreach (Type_Writer writer in type_writer_list)
                {
                    if (writer.id == id)
                    {
                        int salary = writer.set_salary(current_date);

                        listBox1.Items.Add(writer.Name);
                        listBox1.Items.Add(writer.id);
                        listBox1.Items.Add(writer.contact);
                        listBox1.Items.Add(writer.current_salary);
                    }
                }
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Manager")
            {
                foreach(Manager manger in manager_list)
                {   
                    id_list.Add(manger.id);
                    comboBox3.Items.Add(manger.id);
                }
            }
            else if (comboBox2.Text == "Salse_Person")
            {
                foreach (Sales_Person person in sales_person_list)
                {
                    id_list.Add(person.id);
                    comboBox3.Items.Add(person.id);
                }
            }
            else if (comboBox2.Text == "Type_Writer")
            {
                foreach (Type_Writer person in type_writer_list)
                {
                    id_list.Add(person.id);
                    comboBox3.Items.Add(person.id);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
        }
    }
}
