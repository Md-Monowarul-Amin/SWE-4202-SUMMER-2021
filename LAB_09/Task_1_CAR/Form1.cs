using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_1_Library_Car;

namespace Task_1_CAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Seat Pleasant_seat = new Seat("Pleasant", true);
            Wheel big_wheel = new Wheel(26);
            Engine HQ_engine = new Engine(100, 200, 300);
            Door sideway_door = new Door("Sideway");

            Car dummy_car = new Car(Pleasant_seat, big_wheel, HQ_engine, sideway_door);
            dummy_car.display();
            Console.WriteLine("Car_info");
            Console.ReadLine();

        }
    }
}
