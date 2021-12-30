using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Library
{
    public class Hotel
    {

        public List<Room> RoomList;
        public List<User> UserList;
        public List<Booking> BookingList;
    }
    public class User
    {
        public string user_Id;
        public string user_name;
        public string contact_no;
        public string address;
        public Room room;

        public User(string user_Id, string user_name, string contact_no, string address)
        {
            this.user_Id = user_Id;
            this.user_name = user_name;
            this.contact_no = contact_no;
            this.address = address;
        }
    }
    public class Room
    {
        public string room_name;
        public string room_qty;
        public string price;

        public Room(string room_name, string room_qty, string price)
        {
            this.room_name = room_name;
            this.room_qty = room_qty;
            this.price = price;
        }
    }
    
    public class Booking
    {
        
        public string status;
        public string amount;
        public string user_id;
        public string address;
        public int booking_id;
        public string user_name;

        public Booking(string status, string amount, string user_id, string address, int booking_id, string user_name)
        {
            this.status = status;
            this.amount = amount;
            this.user_id = user_id;
            this.address = address;
            this.booking_id = booking_id;
            this.user_name = user_name;
        }
    }
}
