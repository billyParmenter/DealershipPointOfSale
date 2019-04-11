/*
 * FILE          : CustomerWindow.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : This window handles searching for a user
 *                  and spawning a window for adding a new user
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RD_A4
{
    public partial class CustomerWIndow : Form
    {
        //Used for connecting to the database and issuing commands
        private ConnectDB db = new ConnectDB();

        //The event for passing the string of the selected customer
        public event Action<string> PassCustomer;





        // Window constructor
        public CustomerWIndow()
        {
            InitializeComponent();
        }





        /*
         * FUNCTION    : CustomerSearch_Click
         * DESCRIPTION : Check if the last name text box is empty, if it is not then set 'where' to 
         *                  search for the name. If the last name is empty then check if the user 
         *                  entered a phone number if they have then set 'where' to last name. Then 
         *                  search for 'where'. If both are empty then the method does nothing.
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void CustomerSearch_Click(object sender, EventArgs e)
        {
            // Set where to search for last name by default
            string select = lNameTB.Text;
            string where = " WHERE LastName='" + select + "'";

            // If there is nothing in the last name then set where to the phone number
            if (string.IsNullOrWhiteSpace(select) == true)
            {
                select = phoneTB.Text;
                where = " WHERE PhoneNumber='" + select + "'";
            }

            // IF either last name or phone number has something in it then search for all the 
            // customers matching the description
            if (string.IsNullOrWhiteSpace(select) == false)
            {
                // Get the customers
                List<List<string>> seperatedCustomerInfo = db.Select("*", "Customer" + where);
                List<string> customers = new List<string> { };
                string tmpString = "";


                // Parse the customer strings
                if (seperatedCustomerInfo.Count != 0)
                {
                    for (int i = 0; i < seperatedCustomerInfo.Count; i++)
                    {
                        for (int j = 0; j < seperatedCustomerInfo[i].Count; j++)
                        {
                            tmpString = tmpString + seperatedCustomerInfo[i][j] + " ";
                        }
                        customers.Add(tmpString);
                        tmpString = "";
                    }

                    // Set the datasource of the list to the gotten customers
                    customerList.DataSource = customers;
                }

                // If there are no customers found then display a message asking if the user would like to 
                // add a new user
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No customer found..." + Environment.NewLine + "Add new customer?", "404 - Customer Not Found", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddCustomer();
                    }
                }
            }
        }





        /*
         * FUNCTION    : CustomerList_MouseDoubleClick
         * DESCRIPTION : When somthing is double clicked in the list box, get the index that was selected
         *                  and send it back to the windows parent window.
         * PARAMETERS  : object sender    : contains a reference to the control/object that raised the event
         *               MouseEventArgs e : contains the event data
         * RETURNS     : NONE
         */
        private void CustomerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //index double clicked on
            int index = customerList.IndexFromPoint(e.Location);

            // if the index is valid then pass the indexes string back to 
            // the parent window
            if (index > -1)
            {
                PassCustomer(customerList.Items[index].ToString());
                this.Close();
            }
            
        }





        /*
         * FUNCTION    : AddCustomer
         * DESCRIPTION : Spawns a new window for adding a new customer, it also
         *                  subscribes to the child windows 'PassCustomer' event
         * PARAMETERS  : NONE
         * RETURNS     : NONE
         */
        private void AddCustomer()
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.PassCustomer += value => PassCustomer(value);
            addCustomer.ShowDialog();
            this.Close();
        }
    }
}
