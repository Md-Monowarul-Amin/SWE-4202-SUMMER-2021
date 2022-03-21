using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Library
{   

    public class Not_Fount_Exception : ApplicationException
    {
        public override string Message
        {
            get { return "Invalid Id";}

        }
    }



    public abstract class Employee
    {
        public string Name;
        
        public string desig_type;
        public string contact;
        public int joining_date;
        public int current_date;
        public int joining_salary;
    

        public abstract int set_salary(int current_date);

    }

    public class Manager: Employee
    {
        public string id = "M";
        public int current_salary = 10000;
        public Manager(string name, string id, string contact, int joining_date)
        {
            this.Name = name;
            this.id += id;
            this.desig_type = "Manager";
            this.contact = contact; 
            this.joining_date = joining_date;
            this.joining_salary = 10000;
            


        }
        

        public override int set_salary(int current_date)
        {
            int diff = current_date - this.joining_date;
            current_salary  =  current_salary + (int) ((int)(diff / 365) * current_salary * .15);
            return current_salary;
        }



    }
    public class Sales_Person : Employee
    {
        public int current_salary = 5000;
        public string id = "S";
        public Sales_Person(string name, string id, string contact, int joining_date)
        {
            this.Name = name;
            this.id += id;
            this.desig_type = "Sales_Person";
            this.contact = contact;
            this.joining_date = joining_date;
            this.joining_salary = 5000;

        }


        public override int set_salary(int current_date)
        {
            int diff = current_date - this.joining_date;
            current_salary = current_salary + (int)((int)(diff / 365) * current_salary * .10);
            return current_salary;
        }



    }

    public class Type_Writer : Employee
    {
        public string id = "T";
        public int current_salary = 2000;
        public Type_Writer(string name, string id, string contact, int joining_date)
        {
            this.Name = name;
            this.id += id;
            this.desig_type = "Type_Writer";
            this.contact = contact;
            this.joining_date = joining_date;
            this.joining_salary = 2000;

        }


        public override int set_salary(int current_date)
        {
            int diff = current_date - this.joining_date;
            current_salary = current_salary + (int)((int)(diff / 365) * current_salary * .05);
            return current_salary;
        }



    }

}
