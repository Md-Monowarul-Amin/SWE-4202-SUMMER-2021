using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROOM_CLASS_LIBRARY;

namespace ROOM
{
    
    public partial class Form1 : Form
    {
        List<single_room> list_single_room = new List<single_room>();
        List<double_room> list_double_room = new List<double_room>();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ADD_SINGLE_ROOM_Click(object sender, EventArgs e)
        {
            string object_name = textBox1.Text;
            single_room dummy_room = new single_room();
            dummy_room.name = object_name;
            dummy_room.qty =  int.Parse(textBox2.Text);
            dummy_room.air_condition = textBox3.Text;
            dummy_room.gaming_setup = textBox4.Text;
            list_single_room.Add(dummy_room);

            MessageBox.Show("you have to pay "+ dummy_room.Calculate_cost() + "per month");

            
        }

        private void singleQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double_room dummy_double_room = new double_room();
            dummy_double_room.name = textBox8.Text;
            dummy_double_room.qty = int.Parse(textBox7.Text);
            dummy_double_room.air_condition= textBox6.Text;
            dummy_double_room.extra_tv = textBox5.Text;
            dummy_double_room.complementaray_breakfast = textBox9.Text;
            list_double_room.Add(dummy_double_room);

            MessageBox.Show("you have to pay" + dummy_double_room.Calculate_cost() + "per month");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool search = true;
            foreach(single_room dummy_room in list_single_room)
            {
                if (dummy_room.name == textBox10.Text)
                {
                    int room_availability;
                    room_availability = dummy_room.qty - int.Parse(textBox11.Text);
                    if (room_availability < 0)
                    {
                        MessageBox.Show("Room number Out of limit");
                    }
                    else
                    {
                        dummy_room.qty = room_availability;
                        int cal = dummy_room.Calculate_cost() * int.Parse(textBox11.Text);  
                        MessageBox.Show("there exists" + room_availability + " more rooms");
                        MessageBox.Show("you have to pay" + cal + "per month");
                    }
                    search = false;
                    break;

                }
                
            }
            if (search)
            {
                foreach(double_room dummy_room in list_double_room)
                {
                    if (dummy_room.name == textBox10.Text)
                    {
                        int room_availability;
                        room_availability = dummy_room.qty - int.Parse(textBox11.Text);
                        if (room_availability < 0)
                        {
                            MessageBox.Show("Room number Out of limit");
                        }
                        else
                        {
                            dummy_room.qty = room_availability;
                            int cal = dummy_room.Calculate_cost() * int.Parse(textBox11.Text);
                            MessageBox.Show("there exists" + room_availability + "room");
                            MessageBox.Show("you have to pay" + cal + "per month");
                        }

                    }
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string room_name = textBox12.Text;
            bool search = true;
            foreach(single_room room in list_single_room)
            {
                if (room.name == room_name)
                {
                    ROOM_HISTORY.Items.Add(room.name);
                    ROOM_HISTORY.Items.Add("available rooms:" + room.qty);
                    if (room.air_condition == "1")
                    {
                        ROOM_HISTORY.Items.Add("AC available");
                    }
                    else
                    {
                        ROOM_HISTORY.Items.Add("AC not available");
                    }
                    if (room.gaming_setup == "1")
                    {
                        ROOM_HISTORY.Items.Add("gaming available");
                    }
                    else
                    {
                        ROOM_HISTORY.Items.Add("gaming not available");
                    }
                    search = false;
                    break;

                }
            }
            foreach(double_room room in list_double_room)
            {
                if(room.name == room_name)
                {
                    ROOM_HISTORY.Items.Add(room.name);
                    ROOM_HISTORY.Items.Add("available rooms:" + room.qty);
                    if (room.air_condition == "1")
                    {
                        ROOM_HISTORY.Items.Add("AC available");
                    }
                    else
                    {
                        ROOM_HISTORY.Items.Add("AC not available");
                    }
                    
                    ROOM_HISTORY.Items.Add("TV: "+ room.TV);
                }
            }
        }
    }
}
