/*
 * FILE          : AddCustomer.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : Add a customer to the database
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RD_A4
{
    public partial class AddCustomer : Form
    {
        // The database to be used
        private ConnectDB db = new ConnectDB();

        // The event that sends the user back to the parent window as a string
        public event Action<string> PassCustomer;





        // The class constructor
        public AddCustomer()
        {
            InitializeComponent();
        }





        /*
         * FUNCTION    : AddNewCustomer_Click
         * DESCRIPTION : Add a user to the database with the given info
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void AddNewCustomer_Click(object sender, EventArgs e)
        {
            // Insert the customer into the database
            db.Insert("Customer", "FirstName, LastName, PhoneNumber", 
                      "'" + fName.Text + "', '" + lName.Text + "', '" + phoneNumber.Text + "'");

            //Get the customers info back out of the database
            List<List<string>> customers = db.Select("*", 
                                                     "Customer where FirstName='" + fName.Text + 
                                                     "' AND LastName='" + lName.Text + 
                                                     "' AND PhoneNumber='" + phoneNumber.Text + "'");
            List<string> customer = new List<string> { };
            string tmpString = "";

            //parse the string
            if (customers.Count != 0)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    for (int j = 0; j < customers[i].Count; j++)
                    {
                        tmpString = tmpString + customers[i][j] + " ";
                    }
                    customer.Add(tmpString);
                    tmpString = "";
                }

                // Pass the customer back to the parent window
                PassCustomer(customer[0]);
            }
            this.Close();
        }
    }
}
