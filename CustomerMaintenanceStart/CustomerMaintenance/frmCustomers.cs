using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;
using System.IO;
using CustomerMaintenance;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            customerList = CustomerDB.GetCustomers();
            foreach (Customer c in customerList)
            {
                lstCustomers.Items.Add(c.GetDisplayText(" "));
            }
        }

        //List<string> customer = new List<string>;
        private List<Customer> customerList = null;
        private void btnAdd_Click(object sender, EventArgs e)
        {

           frmAddCustomer newfrmAddCustomer= new frmAddCustomer();
            Customer customer = newfrmAddCustomer.GetNewCustomer();
            if(customer!=null)
            {
                customerList.Add(customer);
                CustomerDB.SaveCustomers(customerList);
                FillCustomerListBox();
            }

            


        }
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customerList)
            {
                lstCustomers.Items.Add(c.GetDisplayText(" "));
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if(i!=-1)
            {
                Customer customer = customerList[i];
                string message = "Are you sure you want to delete " + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if(button==DialogResult.Yes)
                {
                    customerList.Remove(customer);
                    CustomerDB.SaveCustomers(customerList);
                    FillCustomerListBox();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}