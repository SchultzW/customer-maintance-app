using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }
        public int Count()
        {
            return customers.Count;
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Add(string firstName, string lastName,string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            customers.Add(c);
        }
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }
        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }
        public Customer this[int i]
        {
            get
            {
                if(i<0||i>=customers.Count)
                    throw new ArgumentOutOfRangeException(i.ToString());
                return customers[i];
            }
           
                
        }
        //public Customer this[string lastName]
        //{
        //    get
        //    {
        //        foreach(Customer c in customers)
        //        {
        //            if (c.LastName == lastName)
        //                return c;
        //        }
        //        return null;
        //    }
        //}
        public Customer this[string email]
        {
            get
            {
                if (email.IndexOf("@") == -1 ||
                      email.IndexOf(".") == -1)
                    throw new ArgumentException("please enter a valid email");
                else
                {
                    foreach (Customer c in customers)
                    {
                        if (c.Email == email)
                            return c;
                    }
                    return null;
                }
            }
            
        }
        public static CustomerList operator +(CustomerList customers, Customer customer)
        {
            customers.Add(customer);
            return customers;
        }
        public static CustomerList operator -(CustomerList customers, Customer customer)
        {
            customers.Remove(customer);
            return customers;
        }
        
    }
}
