using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_LIBRARY
{
    public class User
    {
        public string user_id;
        public string user_name;
        public string address;
        public string Destination;
        public CAR car;

        public User(string user_id, string user_name, string address, string Destination)
        {
            this.user_id = user_id;
            this.user_name = user_name;
            this.address = address;
            this.Destination = Destination;

        }
    }
    public class CAR
    {
        public string car_name;
        public string car_model;
        public string number_of_cars;

        public CAR(string car_name, string car_model, string number_of_cars){
            this.car_name = car_name;
            this.car_model = car_model;
            this.number_of_cars = number_of_cars;

        }
    }

}
