using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAR_LIBRARY;

namespace CAR_RENTAL_SYSTEM
{
    

    public partial class Form1 : Form
    {
        public List<User> user_list = new List<User>();
        public List<CAR> CAR_list = new List<CAR>();
        public List<string> user_id_list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void USER_SAVE_Click(object sender, EventArgs e)
        {
            string user_id = textBox1.Text;
            string user_name = textBox2.Text;
            string user_address = textBox3.Text;
            string user_destination = textBox4.Text;
            User dummy_user = new User(user_id, user_name, user_address, user_destination);
            user_list.Add(dummy_user);
            MessageBox.Show("User info. saved");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();   
        }
        
        private void CAR_SAVE_Click(object sender, EventArgs e)
        {
            string car_name;
            string car_model;
            string car_amount = textBox6.Text;
            car_model = textBox7.Text;
            car_name = textBox8.Text.ToUpper();

            CAR dummy_car = new CAR(car_name, car_model,car_amount);
            CAR_list.Add(dummy_car);
            MessageBox.Show("Car Stored");
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void RENT_CAR_Click(object sender, EventArgs e)
        {
            string car_name = textBox9.Text.ToUpper();
            string user_id = textBox10.Text;
            foreach(User dummy_user in user_list)
            {
                if (dummy_user.user_id == user_id)
                {
                    foreach (CAR car in CAR_list)
                    {
                        if (car.car_name == car_name)
                        {
                            int x = int.Parse(car.number_of_cars);
                            Convert.ToInt32(x);
                            x = x - 1;
                            Convert.ToString(x);
                            car.number_of_cars = x.ToString();
                            dummy_user.car = car;
                            MessageBox.Show("Rent Successful");
                        }
                    }
                    
                }
            }
            
        }

        private void SHOW_USER_HISTORY_Click(object sender, EventArgs e)
        {
            string user_id = textBox13.Text;
            foreach(User user in user_list)
            {
                if (user.user_id == user_id)
                {
                    Show_User_NAME.Text = user.user_name;
                    show_Address.Text = user.address;
                    show_Destination.Text = user.Destination;
                    show_car.Text = user.car.car_name;

                }
            }
        }

        private void SHOW_CAR_HISTORY_Click(object sender, EventArgs e)
        {
            string car_name = car_name_input.Text.ToUpper();
            foreach(CAR car in CAR_list)
            {
                if (car.car_name == car_name)
                {
                    show_car_available_unit.Text = car.number_of_cars;
                    show_car_model.Text = car.car_model;
                } 
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void show_car_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
