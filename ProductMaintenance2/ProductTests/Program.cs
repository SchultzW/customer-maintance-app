using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMaintenanceClasses;


namespace ProductTests
{
    class Program
    {
        static void Main(string[] args)
        {

            TestProductConstructors();
            TestProductPropertyGetters();
            TestProductPropertySetters();
            TestProductToString();

            //TestProductAll();

            Console.WriteLine();
            Console.ReadLine();
            //must right click on ProductTests in the solution explorer then set as startup project
            //test every method you create
        }

        static void TestProductConstructors()
        {
            Product p1 = new Product();//2 consturctos one with no parameters one with 3
            Product p2 = new Product("T100", "This is a test product", 100M);//pick 3 literal values to pass to the constructor

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + p1.GetDisplayText(", "));
            Console.WriteLine("Overloaded constructor.  Expecting T100, 100, This is a test product. " + p2.GetDisplayText("\t"));//output what we expect to see and the values
            Console.WriteLine();//blank line to seperate different tests
        }

        static void TestProductPropertyGetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);//creates new product.

            Console.WriteLine("Testing getters");
            Console.WriteLine("Code.  Expecting T100. " + p1.Code);
            Console.WriteLine("Description.  Expecting This is a test product. " + p1.Description);
            Console.WriteLine("Price.  Expecting 100. " + p1.Price);
            Console.WriteLine();
        }

        static void TestProductPropertySetters()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing setters");
            p1.Code = "T000";//calls a setter to change the code
            p1.Description = "First product";//change the descrpition
            p1.Price = 200;
            Console.WriteLine("Expecting T000, 200, First product. " + p1.GetDisplayText(", "));
            Console.WriteLine();
        }

        static void TestProductToString()
        {
            Product p1 = new Product("T100", "This is a test product", 100M);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1.ToString());
            Console.WriteLine("Expecting T100, 100, This is a test product. " + p1);//this sees how product.tostring method and just the prduct name are different
            Console.WriteLine();//these may be same as there is a deafult ToString method
        }

        static void TestProductAll()//different way to write the call to methods...
        {
            TestProductConstructors();
            TestProductPropertyGetters();
            TestProductPropertySetters();
            TestProductToString();
            Console.WriteLine();
        }
    }
}
