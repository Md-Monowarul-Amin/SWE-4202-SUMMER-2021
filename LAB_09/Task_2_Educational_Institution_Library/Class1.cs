using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Educational_Institution_Library
{
    public abstract class Staff
    {
        public string name;
        public string id;

        public void Who_Am_I(string am_id)
        {
            string type = null;
            string id_mod = Convert.ToString(am_id[0]) + Convert.ToString(am_id[1]) + Convert.ToString(am_id[2]);

            if(id_mod == "Tea")
            {
                type = "Teacher";
            }
            else if(id_mod == "Typ")
            {
                string mod_n = Convert.ToString(am_id[0]) + Convert.ToString(am_id[1]) + Convert.ToString(am_id[2]);
                if (mod_n == "Reg")
                {
                    type = "Regula_Typist";
                }
                else
                {
                    type = "Casual_Typist";
                }
            }
            else if(id_mod == "Off")
            {
                type = "Officer";
            }

            Console.WriteLine(type);
        }
    }

    public class Teacher:Staff
    {
        string subject;
        string publication;

        public Teacher(string name, string id,  string suject, string publication)
        {
            this.subject = suject;
            this.publication = publication;
            this.name = name;
            this.id = "Tea" + id;

        }

    }

    public abstract class Typist:Staff
    {
        public string speed;

    }


    public class Regular : Typist
    {
        public Regular(string name, string id, string speed)
        {
            this.name=name; 
            this.id="Typ" + "Reg" + id;
            this.speed =speed;
        }
    }


    public class Casual : Typist
    {
        bool daily;
        bool wages;

        public Casual(string name, string id, string speed, bool daily, bool wages)
        {
            this.name = name;
            this.id = this.id +"Typ" + "Cas" + id;
            this.speed =speed;
            this.daily =daily;
            this.wages =wages;

        }

    }

    public class Officer : Staff
    {
        string Grade;

        public Officer(string name, string id, string grade)
        {
            this.name = name;
            this.id = "Off" + id;
            this.Grade = grade;
        }
    }
}
