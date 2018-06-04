using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer() { }

        public Customer(string firstName,string lastName,string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;

            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {   //can just do get;set;
            get
            {
                return email;

            }
            set
            {
                email = value;
            }
        }
        public string GetDisplayText(string sep)
        {
            return FirstName + sep + lastName + "," +sep+ email;
        }
        public string ToString()
        {
            return GetDisplayText("\t");
        }
        public static bool operator ==(Customer c1, Customer c2)
        {
            if (object.Equals(c1, null))
                if (object.Equals(c2, null))
                    return true;
                else
                    return false;
            else
                return c1.Equals(c2);
        }
        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1 == c2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Customer c = (Customer)obj;
            if (this.LastName == c.LastName &&
                this.FirstName == c.FirstName &&
                this.Email == c.Email)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            string hashString = this.FirstName + this.LastName + this.Email;
            return hashString.GetHashCode();
        }



    }
}
