using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Library;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {   
        public Hotel new_hotel = new Hotel();
        public List<Room> room_list = new List<Room>();
        public List<User> user_list = new List<User>();
        public List<Booking> booking_list = new List<Booking>();
        

        

        int balance = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            Room room1 = new Room("Single_suite", "5", "1000");
            Room room2 = new Room("Double_suite", "5", "2000");
            Room room3 = new Room("Single_deluxe", "5", "1500");
            Room room4 = new Room("Double_deluxe", "5", "3000");



            room_list.Add(room1);
            room_list.Add(room2);
            room_list.Add(room3);
            room_list.Add(room4);

            comboBox2.Items.Add(room1.room_name);
            comboBox2.Items.Add(room2.room_name);
            comboBox2.Items.Add(room3.room_name);
            comboBox2.Items.Add(room4.room_name);

            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Confirmed");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ROOM_DETAILS_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            string user_id = textBox2.Text;
            string name = textBox3.Text;
            string contact = textBox4.Text;
            string address = textBox5.Text;

            User dummy_user = new User(user_id, name, contact, address);
            user_list.Add(dummy_user);
            MessageBox.Show("user account created");

        }

        public int booking_id = 0;
        private void PlaceBooking_Click(object sender, EventArgs e)
        {
            string user_id = textBox9.Text;
            int price = 0;
            string room_name = comboBox2.Text;
            foreach (Room room in room_list)
            {
                if (room.room_name == room_name)
                {
                    int room_qty = int.Parse(room.room_qty);
                    price = int.Parse(room.price);
                    for (int i = 1; i <= room_qty; i++)
                    {   string j = i.ToString(); 
                        comboBox3.Items.Add(j);
                    }

                }
            }
          
            int departure_date = int.Parse(textBox6.Text);
            int entry_date = int.Parse(textBox7.Text);
            int duration = departure_date - entry_date;
            string address= "";
            string user_name = "";

            int totoal_amount = 0; 
            foreach(User user in user_list)
            {
                if (user.user_Id == user_id)
                {
                    address = user.address;
                    user_name = user.user_name;
                    break;
                }
            }
            
            int quantity = int.Parse(comboBox3.Text);
            totoal_amount = price * quantity * duration;
            balance += totoal_amount;
            string total_amount_str;
            total_amount_str = totoal_amount.ToString();
            booking_id  = booking_id + 1;
            string status = "Pending";

            Booking dummy_book = new Booking(status, total_amount_str, user_id, address, booking_id, user_name);
            booking_list.Add(dummy_book);
            MessageBox.Show("Booking Placesd");

        }


        private void Set_Status_Click(object sender, EventArgs e)
        {
            int booking_id = int.Parse(textBox1.Text);
            foreach (Booking booking in booking_list)
            {
                if (booking.booking_id == booking_id)
                {
                    booking.status = comboBox1.Text;
                    label4.Text = balance.ToString();
                    MessageBox.Show("status set");
                    break;
                }
            }
        }

        private void SeeOrderDetails_Click(object sender, EventArgs e)
        {
            int booking_id =  int.Parse(textBox13.Text);
            foreach (Booking booking in booking_list)
            {
                if (booking.booking_id == booking_id)
                {
                    label20.Text = booking.status;
                    label22.Text = booking.amount;
                    label24.Text = booking.user_name;
                    label23.Text = booking.address;
                    
                    break;
                }
            }

        }
    }
}
