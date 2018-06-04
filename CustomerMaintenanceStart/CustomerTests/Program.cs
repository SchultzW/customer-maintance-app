using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;



namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstructors();
            TestCustomerGetter();
            TestCustomerSetter();
            TestToString();
            TestListConstructorsandAdd();
            TestOverloadOperators();
            TestRelationalOverload();

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void TestOverloadOperators()
        {
            Console.WriteLine();
            Console.WriteLine("testing overloaded operators");
            Console.WriteLine("testing +");
            CustomerList customers = new CustomerList();
            Customer c1 = new Customer("Michael", "Michaelerson", "MicaelMichaelerson@gmail.com");
            Customer c2 = new Customer("will", "schultz", "will@willmail.com");
            Customer c3 = new Customer("jim", "jimmerson", "Jim@jimmail.com");
            customers.Add(c1);
            customers.Add(c3);
            customers=customers + c2;
            Console.WriteLine("expecting customers[0]:   " + customers[0].ToString());
            Console.WriteLine("expecting customers[1]:   " + customers[1].ToString());
            Console.WriteLine("expecting customers[2]:   " + customers[2].ToString());
            Console.WriteLine("testing -   removing customer c1 michael");
            customers = customers - c1;
            Console.WriteLine(customers[1].ToString());
            
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();//deafult constuctor
            Customer c2 = new Customer("Jim", "Jimmerson", "Jimjimmerson@hotmail.com");
            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Deafult Constructor. expecting deafult values." + c1.GetDisplayText(","));
            Console.WriteLine("overload constructor. expecting Jim Jimmerson,Jimjimmerson@hotmail.com  :  "+c2.GetDisplayText(" "));
            Console.WriteLine("");
        }
        static void TestCustomerGetter()
        {
            Customer c1 = new Customer("Fred", "Fredderson", "FredFredderson@aol.com");
            Console.WriteLine("testing getters");
            Console.WriteLine("first name, expecting Fred  :  " + c1.FirstName);
            Console.WriteLine("Last name, expecting Fredderson  :  " + c1.LastName);
            Console.WriteLine("email, expecting FredFredderson@aol.com  :  "+c1.Email);
            Console.WriteLine("");
            

        }
        static void TestCustomerSetter()
        {
            Customer c1 = new Customer("Matt", "Matterson", "MattMatterson@gmail.com");
            Console.WriteLine("Testing Setters");
            c1.FirstName = "Will";
            c1.LastName = "Willerson";
            c1.Email = "WillWillerson@gmail.com";
            Console.WriteLine("expecting Will Willerson @ WillWillerson@gmail.com :   " + c1.GetDisplayText(","));
            Console.WriteLine("");

        }
        static void TestToString()
        {
            Customer c1 = new Customer("Michael", "Michaelerson", "MicaelMichaelerson@gmail.com");
            Console.WriteLine("testing to string method");
            Console.WriteLine("expecting Michael, Michaelerson, MicaelMichaelerson@gmail.com :   " + c1.ToString());
            Console.WriteLine("expecting Michael, Michaelerson, MicaelMichaelerson@gmail.com :   " + c1);

        }
        static void TestListConstructorsandAdd()
        {
            Console.WriteLine();
            Console.WriteLine("testing class list");
            CustomerList customers = new CustomerList();
            Customer c1 = new Customer("Michael", "Michaelerson", "MicaelMichaelerson@gmail.com");
            customers.Add(c1);
            Console.WriteLine("testing the count() and deafult constructor");
            double count = customers.Count();
            Console.WriteLine("should be a count of 1:  " + count);
            Console.WriteLine("testing if overload add works. Also test if deafult int[i] indexer works");

            customers.Add("fred", "fredderson", "fredfredderson@gmail.com");
            Console.WriteLine("should display fred fredderson at fredfredderson@gmail.com");
            Console.WriteLine(customers[1].ToString());
            Console.WriteLine("testing email indexer");
            Console.WriteLine("expecting 1" + customers["fredfredderson@gmail.com"].ToString());
            //Console.WriteLine("expecting error" + customers["fredfredderson"]);


        }
        static void TestRelationalOverload()
        {
            Console.WriteLine("testing relational overload== and !-");
            Customer c = new Customer("jim", "jimmerson", "jim@gmail.com");
            Customer c1 = new Customer("jim", "jimmerson", "jim@gmail.com");
            Customer c3 = new Customer("will", "schultz", "will@gmail.com");

            Console.WriteLine("c= " + c.GetDisplayText(" "));
            Console.WriteLine("c1=" + c1.GetDisplayText(" "));
            if (c == c1)
                Console.WriteLine("c and c1 customers are the same");
            else
                Console.WriteLine("something went wrong...");
            Console.WriteLine("testing relational overload !=");
            Console.WriteLine("c=" + c.GetDisplayText(" "));
            Console.WriteLine("c3=" + c3.GetDisplayText(" "));
            if (c != c3)
                Console.WriteLine(" c and c3 are not equal");
            else
                Console.WriteLine("something went wrong");
        }

    }
}
