/*
 * FILE          : VehicleWindow.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : This class has methods for searching the
 *                  database for specific car by a given VIN
 *                  or for any cars matching year, make, and
 *                  model. Then it will pass a car selected
 *                  by the user.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RD_A4
{
    public partial class VehicleWindow : Form
    {
        //Used for connecting to the database and issuing commands
        private ConnectDB db = new ConnectDB();

        //The event for passing the string of the selected car
        public event Action<string> PassCar;





        //Window constructor
        public VehicleWindow()
        {
            InitializeComponent();
        }





        /*
         * FUNCTION    : VehicleSearch_Click
         * DESCRIPTION : Check if the vin is empty, if it is not then set 'where' to search for the vin.
         *                  If the vin is empty then check if the user entered year, make, and model, if they
         *                  have then set 'where' to search for any cars matching the description. If not then
         *                  the method does nothing
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void VehicleSearch_Click(object sender, EventArgs e)
        {
            string where = "";          //The search parameter(s)
            bool emptyStrings = true;   //Weather if both the vin and descriptions are empty



            // Check if the vin is null
            if (string.IsNullOrWhiteSpace(vin.Text) == false)
            {
                where = " WHERE VIN='" + vin.Text + "'";
                emptyStrings = false;
            }

            // Check if any of the description is null
            else if (string.IsNullOrWhiteSpace(year.Text) == false &&
                     string.IsNullOrWhiteSpace(make.Text) == false &&
                     string.IsNullOrWhiteSpace(model.Text) == false)
            {
                where = " WHERE vYear=" + year.Text + " AND Make='" + make.Text + "' AND Model='" + model.Text + "'";
                emptyStrings = false;
            }



            // If both strings arent empty, search using the where string
            if (emptyStrings == false)
            {
                // Get the search results
                List<List<string>> vehicles = db.Select("*", "Vehicle" + where);
                List<string> cars = new List<string> { };
                string tmpString = "";

                // Parse the results
                if (vehicles.Count != 0)
                {
                    for (int i = 0; i < vehicles.Count; i++)
                    {
                        for (int j = 0; j < vehicles[i].Count; j++)
                        {
                            tmpString = tmpString + vehicles[i][j] + " ";
                        }
                        cars.Add(tmpString);
                        tmpString = "";
                    }

                    //Set the list box data source to the cars gotten from the search
                    vehicleList.DataSource = cars;
                }

                // If there is nothing found then display a message
                else
                {
                    DialogResult dialogResult = MessageBox.Show("The car specified was not found.", "404 - Car Not Found", MessageBoxButtons.OK);
                }
            }
        }





        /*
         * FUNCTION    : VehicleList_MouseDoubleClick
         * DESCRIPTION : When somthing is double clicked in the list box, get the index that was selected
         *                  and send it back to the windows parent window.
         * PARAMETERS  : object sender    : contains a reference to the control/object that raised the event
         *               MouseEventArgs e : contains the event data
         * RETURNS     : NONE
         */
        private void VehicleList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Index that was double clicked
            int index = vehicleList.IndexFromPoint(e.Location);

            // If the indes is valid then send the string in the index back to the
            // parent window
            if (index > -1)
            {
                PassCar(vehicleList.Items[index].ToString());
                this.Close();
            }
        }
    }
}
