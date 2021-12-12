using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROOM_CLASS_LIBRARY
{
    public class ROOM
    {
        public string name;
        public int TV = 1;
        public int refrigerator = 1;
        public int qty;
        public string air_condition;

    }
    public class single_room : ROOM
    {
        public int bed = 1;
        public string gaming_setup;
        public int base_cost = 2000;
        public string Calculate_cost()
        {
            int cost = base_cost;
            if (air_condition == "1")
            {
                cost = cost + 500;
            }
            if (gaming_setup == "1")
            {
                cost = cost + 1000;
            }
            string cost_str = cost.ToString();
            return cost_str;
        }

    }
    public class double_room : ROOM
    {
        public int bed = 2;
        public int base_cost = 3500;
        public string extra_tv;
        public string complementaray_breakfast;

        public int Calculate_cost()
        {
            int cost = base_cost;
            if (air_condition == "1")
            {
                cost = cost + 500;
            }
            if (extra_tv == "1")
            {
                cost += 1000;
            }
            if (complementaray_breakfast == "1")
            {
                cost = cost + 500;
            }
            return cost;
        }

    }
}


