/*
 * FILE          : MainSceen.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : This is the main screen of the application.
 *                  It handles button click events, user input
 *                  and spawning child windows.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RD_A4
{
    public partial class MainScreen : Form
    {
        ConnectDB db = new ConnectDB();

        private string customerID;          // The id of the customer
        private string fName;               // The first name of the customer
        private string lName;               // The last name of the customer
        private string phoneNumber;         // The phone number of the customer
        private string orderStatus;         // The order status of the order

        private string vin;                 // The vehicle identification number(vin) of the vehicle
        private string year;                // The year of the vehicle
        private string make;                // The make of the vehicle
        private string model;               // The modle of the vehicle
        private string colour;              // The colour of the vehicle
        private string kms;                 // The kilometers on the vehicle
        private string wPrice;              // The wholesale price of the vehicle
        private string inStock;             // The stock status of the vehicle

        private string currentOrderStatus;  // The current order status
        private string orderID;             // The id of the order





        // Class constructor
        public MainScreen()
        {
            InitializeComponent();
        }





        /*
         * FUNCTION    : OrderBT_Click
         * DESCRIPTION : Hide and displays the appropriate controls for making an order
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void OrderBT_Click(object sender, EventArgs e)
        {
            customerBox.Visible = true;
            vehicleBox.Visible = true;
            tradeInBox.Visible = true;
            DisableButtons();
            yesTradeIn.Select();
            paidBTN.Checked = false;
            holdBTN.Checked = false;
        }





        /*
         * FUNCTION    : OrderLookupBT_Click
         * DESCRIPTION : Hide and displays the appropriate controls for looking up an order
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void OrderLookupBT_Click(object sender, EventArgs e)
        {
            vehicleBox.Visible = true;
            orderBox.Visible = true;
            customerBox.Visible = true;
            tradeInBox.Visible = true;
            orderUpdateBox.Visible = true;
            orderUpdate.Visible = true;
            DisableButtons();
        }





        /*
         * FUNCTION    : InventoryBT_Click
         * DESCRIPTION : Hide and displays the appropriate controls for looking at the inventory, then
         *                  populates the inventorys list box
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void InventoryBT_Click(object sender, EventArgs e)
        {
            inventoryList.Visible = true;
            DisableButtons();

            // Colunms for displaying info
            List<string> columns = new List<string> { "VIN: ", " Year: ", " Make: " , " Model: ",
                                                      " Colour: ", " Kms: ", " Price: ", " In Stock: " };

            //Get all vehicles in the database
            List<List<string>> inventory = db.Select("*", "Vehicle");
            List<string> cars = new List<string> { };
            string tmpString = "";

            // Parse the strings
            if (inventory.Count != 0)
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    for (int j = 0; j < inventory[i].Count; j++)
                    {
                        tmpString = tmpString + columns[j] + inventory[i][j] + " ";
                    }
                    cars.Add(tmpString);
                    tmpString = "";
                }

                // Set the lists datasource
                inventoryList.DataSource = cars;
            }
        }





        /*
         * FUNCTION    : BackBT_Click
         * DESCRIPTION : hides controls and displays the main menu
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void BackBT_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            orderBT.Enabled = true;
            orderLookupBT.Enabled = true;
            inventoryBT.Enabled = true;
            backBT.Enabled = false;
            customerBox.Visible = false;
            vehicleBox.Visible = false;
            orderBox.Visible = false;
            inventoryList.Visible = false;
            tradeInBox.Visible = false;
            orderUpdateBox.Visible = false;
            customerInfo.Text = "";
            vehicleInfo.Text = "";
            vinTB.Text = "";
            yearTB.Text = "";
            makeTB.Text = "";
            modelTB.Text = "";
            colourTB.Text = "";
            kmsTB.Text = "";
            priceTB.Text = "";
            orderInfoLabel.Text = "";
        }





        /*
         * FUNCTION    : CustomerInfoBT_Click
         * DESCRIPTION : Spawns a window to get customer info, displays it and then populates the order list box with only
         *                  the given customers orders
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void CustomerInfoBT_Click(object sender, EventArgs e)
        {
            string tmpString = "";

            // Open the customer window to get the customers info
            CustomerWIndow customerWIndow = new CustomerWIndow();
            customerWIndow.PassCustomer += value => tmpString = value;
            customerWIndow.ShowDialog();

            // Parse the customers info
            string[] splitString = tmpString.Split(' ');

            //Populate the customer info lable and set some class values
            if (string.IsNullOrWhiteSpace(tmpString) == false)
            {
                customerInfo.Text = "Customer ID: " + splitString[0] + Environment.NewLine + Environment.NewLine +
                                    "First Name: " + splitString[1] + Environment.NewLine + Environment.NewLine +
                                    "Last Name: " + splitString[2] + Environment.NewLine + Environment.NewLine +
                                    "Phone Number: " + splitString[3];
                customerID = splitString[0];
                fName = splitString[1];
                lName = splitString[2];
                phoneNumber = splitString[3];
            }


            
            //Get the customers orders
            List<List<string>> orderInfo = db.Select("*", "CustomerOrder WHERE CustomerID=" + customerID);
            List<string> orders = new List<string> { };
            tmpString = "";

            //Parse the orders
            if (orderInfo.Count != 0)
            {
                for (int i = 0; i < orderInfo.Count; i++)
                {
                    for (int j = 0; j < orderInfo[i].Count; j++)
                    {
                        tmpString = tmpString + orderInfo[i][j] + " ";
                    }
                    orders.Add(tmpString);
                    tmpString = "";
                }

            }

            //populate the order list box
            orderList.DataSource = orders;
            orderLable.Text = "";

        }





        /*
         * FUNCTION    : DisableButtons
         * DESCRIPTION : Disable the buttons when clicking on a menu item
         * PARAMETERS  : NONE
         * RETURNS     : NONE
         */
        private void DisableButtons()
        {
            pictureBox.Visible = false;
            orderBT.Enabled = false;
            orderLookupBT.Enabled = false;
            inventoryBT.Enabled = false;
            backBT.Enabled = true;
        }





        /*
         * FUNCTION    : VehicleInfoBT_Click
         * DESCRIPTION : Spawns a window for getting vehicle info, parses the string and siplays the info
         *                  and sets some class variables
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void VehicleInfoBT_Click(object sender, EventArgs e)
        {
            string tmpString = "";

            //spawns the window to get the vehicles info
            VehicleWindow vehicleWindow = new VehicleWindow();
            vehicleWindow.PassCar += value => tmpString = value;
            vehicleWindow.ShowDialog();

            //Parse the string
            string[] splitString = tmpString.Split(' ');

            //Display the cars info
            if (string.IsNullOrWhiteSpace(tmpString) == false)
            {
                vehicleInfo.Text = "VIN: " + splitString[0] + Environment.NewLine +
                                   "Year: " + splitString[1] + Environment.NewLine +
                                   "Make: " + splitString[2] + Environment.NewLine +
                                   "Model: " + splitString[3] + Environment.NewLine +
                                   "Colour: " + splitString[4] + Environment.NewLine +
                                   "Kms: " + splitString[5] + Environment.NewLine +
                                   "Price: " + splitString[6] + Environment.NewLine +
                                   "In Stock: " + splitString[7];
            }

            //set the class variables
            vin = splitString[0];
            year = splitString[1];
            make = splitString[2];
            model = splitString[3];
            colour = splitString[4];
            kms = splitString[5];
            wPrice = splitString[6];
            inStock = splitString[7];


            //Only allow the user to order only if the car selected is available
            if (inStock == "YES")
            {
                submit.Enabled = true;
            }
            else
            {
                submit.Enabled = false;
            }

        }





        /*
         * FUNCTION    : YesTradeIn_CheckedChanged
         * DESCRIPTION : If the user wishes to make a trade in make the pannel visible
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void YesTradeIn_CheckedChanged(object sender, EventArgs e)
        {
            tradeInPannel.Visible = true;
        }




        /*
         * FUNCTION    : NoTradeIn_CheckedChanged
         * DESCRIPTION : If no trade in then hide the pannel
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void NoTradeIn_CheckedChanged(object sender, EventArgs e)
        {
            tradeInPannel.Visible = false;
        }





        /*
         * FUNCTION    : Submit_Click
         * DESCRIPTION : Once the user completess an order check if itd with a trade in or not and call
         *                  generate order depending on that faact
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void Submit_Click(object sender, EventArgs e)
        {
            bool tradeIn = true;

            //If there is a customer selected, vehicle selected, and the hold or paid button is selected
            if (string.IsNullOrWhiteSpace(customerInfo.Text) == false && 
                string.IsNullOrWhiteSpace(vehicleInfo.Text) == false && 
                (paidBTN.Checked == true || holdBTN.Checked == true))
            {

                //If there is a trade in is not selected then generate an order
                if (noTradeIn.Checked == true)
                {
                    error.Text = "";
                    tradeIn = false;
                    GenerateOrder(tradeIn);
                }

                //If trade in is selected then make sure all the requred feilds are valid
                else if (yesTradeIn.Checked == true &&
                         string.IsNullOrWhiteSpace(vinTB.Text) == false &&
                         string.IsNullOrWhiteSpace(yearTB.Text) == false &&
                         string.IsNullOrWhiteSpace(makeTB.Text) == false &&
                         string.IsNullOrWhiteSpace(modelTB.Text) == false &&
                         string.IsNullOrWhiteSpace(colourTB.Text) == false &&
                         string.IsNullOrWhiteSpace(kmsTB.Text) == false &&
                         string.IsNullOrWhiteSpace(priceTB.Text) == false)
                {
                    error.Text = "";
                    GenerateOrder(tradeIn);
                }

                else
                {
                    error.Text = "Missing fields";
                }

            }
            else
            {
                error.Text = "Missing fields";
            }
        }





        /*
         * FUNCTION    : GenerateOrder
         * DESCRIPTION : Generates a receipt for a customer
         * PARAMETERS  : bool tradeIn : weaher or not there is a trade in
         * RETURNS     : NONE
         */
        private void GenerateOrder(bool tradeIn)
        {
            string date = DateTime.Now.ToString();

            orderStatus = GetOrderStatus();
            string inStock = "";


            // Sets the inStock status depending on is the customer is putting the car on hold or paying for it
            if (orderStatus == "PAID")
            {
                inStock = "NO";
            }
            else
            {
                inStock = "HOLD";
            }


            // Generate the receipt for no trade in
            if (tradeIn == false)
            {

                db.Insert("CustomerOrder", "CustomerID, OrderDate, OrderStatus, DealerID", 
                          "'" + customerID + "', '" + date + "', '" + orderStatus + "', 2");
                db.Insert("OrderLine", 
                          "Vehicle, OrderID", "'" + vin + 
                          "', (SELECT OrderID FROM CustomerOrder WHERE CustomerID =" + customerID + 
                          " AND OrderDate='" + date + "')");
                db.Update("Vehicle", "inStock='" + inStock + "'", "VIN='" + vin + "'");
                List<List<string>> oID = db.Select("OrderID", "CustomerOrder WHERE OrderDate='" + date + "'");

                string receiptStr = "Date: " + date + Environment.NewLine +
                                    "Customer: " + fName + " " + lName + Environment.NewLine +
                                    "OrderID: " + oID[0][0] + " - " + orderStatus + Environment.NewLine + 
                                    Environment.NewLine + 
                                    year + " " + make + " " + model + ", " + colour + Environment.NewLine + 
                                    "VIN: " + vin + " KMS: " + kms + Environment.NewLine +
                                    Environment.NewLine + 
                                    "Purchace Price: $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    Environment.NewLine +
                                    "Trade In: N/A" + Environment.NewLine +
                                    Environment.NewLine +
                                    "Subtotal = $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    "HST (13%) = $" + (float.Parse(wPrice) * 0.13).ToString() + Environment.NewLine +
                                    "Sale Total = $" + (float.Parse(wPrice) * 1.4 + (float.Parse(wPrice) * 0.13));
                MessageBox.Show(receiptStr, "Order Receipt", MessageBoxButtons.OK);

            }

            //Generats the receipt for a trade in
            else
            {
                db.Insert("CustomerOrder", "CustomerID, OrderDate, OrderStatus, DealerID",
                          "'" + customerID + "', '" + date + "', '" + orderStatus + "', 2");
                db.Insert("OrderLine",
                          "Vehicle, OrderID", "'" + vin +
                          "', (SELECT OrderID FROM CustomerOrder WHERE CustomerID =" + customerID +
                          " AND OrderDate='" + date + "')");
                db.Update("Vehicle", "inStock='" + inStock + "'", "VIN='" + vin + "'");
                db.Insert("Vehicle", "	VIN, vYear, Make, Model, Colour, kms, wPrice, inStock", 
                          "'" + vinTB.Text + "', '" + yearTB.Text + "', '" + makeTB.Text + 
                          "', '" + modelTB.Text + "', '" + colourTB.Text + "', '" + kmsTB.Text + 
                          "', '" + priceTB.Text + "', 'YES'");
                List<List<string>> oID = db.Select("OrderID", "CustomerOrder WHERE OrderDate='" + date + "'");


                string receiptStr = "Date: " + date + Environment.NewLine +
                                    "Customer: " + fName + " " + lName + Environment.NewLine +
                                    "OrderID: " + oID[0][0] + " - " + orderStatus + Environment.NewLine +
                                    Environment.NewLine +
                                    year + " " + make + " " + model + ", " + colour + Environment.NewLine +
                                    "VIN: " + vin + " KMS: " + kms + Environment.NewLine +
                                    Environment.NewLine +
                                    "Purchace Price: $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    Environment.NewLine +
                                    "Trade In: -$" + priceTB.Text + Environment.NewLine +
                                    Environment.NewLine +
                                    "Subtotal = $" + ((float.Parse(wPrice) * 1.4) - float.Parse(priceTB.Text)).ToString() + Environment.NewLine +
                                    "HST (13%) = $" + (((float.Parse(wPrice) * 1.4) - float.Parse(priceTB.Text)) * 0.13).ToString() + Environment.NewLine +
                                    "Sale Total = $" + (((float.Parse(wPrice) * 1.4) - float.Parse(priceTB.Text)) + ((float.Parse(wPrice) * 1.4) - float.Parse(priceTB.Text)) * 0.13);
                MessageBox.Show(receiptStr, "Order Receipt", MessageBoxButtons.OK);
            }
        }





        /*
         * FUNCTION    : GetOrderStatus
         * DESCRIPTION : Gets the order status
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private string GetOrderStatus()
        {
            if (paidBTN.Checked == true)
            {
                orderStatus = "PAID";
            }
            else
            {
                orderStatus = "HOLD";
            }

            return orderStatus;
        }





        /*
         * FUNCTION    : OrderSelectBT_Click
         * DESCRIPTION : Displays orders info
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void OrderSelectBT_Click(object sender, EventArgs e)
        {
            refundRB.Enabled = true;
            holdRB.Enabled = true;
            paidRB.Enabled = true;
            cancelRB.Enabled = true;
            string[] order = orderList.SelectedItem.ToString().Split(' ');

            //Gets the vin of a car in an order
            List<List<string>> oVin = db.Select("vehicle", "OrderLine WHERE OrderID='" + order[0] + "'");
            vin = oVin[0][0];

            //Display orders info
            orderLable.Text = "OrderID: " + order[0] + Environment.NewLine +
                              "CustomerID: " + order[1] + Environment.NewLine +
                              "Date: " + order[2] + " " + order[3] + " " + order[4] + Environment.NewLine +
                              "Status: " + order[5] + Environment.NewLine +
                              "DealerID: " + order[6] + Environment.NewLine +
                              "VIN: " + vin;
            currentOrderStatus = order[5];
            orderID = order[0];


            //hide or display buttons that are availeable depending on the current order status
            if (currentOrderStatus == "PAID")
            {
                paidRB.Checked = true;
                cancelRB.Enabled = false;
                holdRB.Enabled = false;
            }
            else if (currentOrderStatus == "HOLD")
            {
                holdRB.Checked = true;
                refundRB.Enabled = false;
            }
            else if (currentOrderStatus == "REFUND")
            {
                refundRB.Checked = true;
                cancelRB.Enabled = false;
                paidRB.Enabled = false;
                holdRB.Enabled = false;
            }
            else
            {
                refundRB.Enabled = false;
                holdRB.Enabled = false;
                paidRB.Enabled = false;
                cancelRB.Checked = true;
            }
        }





        /*
         * FUNCTION    : UpdateBT_Click
         * DESCRIPTION : Updates an order and generate recipts
         * PARAMETERS  : object sender : contains a reference to the control/object that raised the event
         *               EventArgs e   : contains the event data
         * RETURNS     : NONE
         */
        private void UpdateBT_Click(object sender, EventArgs e)
        {
            string updatedStatus = "";

            string date = DateTime.Now.ToString();


            //Gets the updatedStatus
            if (paidRB.Checked == true)
            {
                updatedStatus = "PAID";
            }
            else if (holdRB.Checked == true)
            {
                updatedStatus = "HOLD";
            }
            else if (refundRB.Checked == true)
            {
                updatedStatus = "REFUND";
            }
            else
            {
                updatedStatus = "CANCEL";
            }



            //Updates the order and generates a receipt
            if (currentOrderStatus == updatedStatus)
            {
                //do nothing
            }
            else if(updatedStatus == "REFUND")
            {
                //make recipt
                db.Update("vehicle", "inStock='YES'", "VIN='" + vin + "'");
                db.Update("CustomerOrder", "OrderStatus='REFUND'", "OrderID='" + orderID + "'");

                string receiptStr = "Date: " + date + Environment.NewLine +
                                    "Customer: " + fName + " " + lName + Environment.NewLine +
                                    "OrderID: " + orderID + " - " + updatedStatus + Environment.NewLine +
                                    Environment.NewLine +
                                    year + " " + make + " " + model + ", " + colour + Environment.NewLine +
                                    "VIN: " + vin + " KMS: " + kms + Environment.NewLine +
                                    Environment.NewLine +
                                    "Purchace Price: $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    Environment.NewLine +
                                    "Trade In: N/A" + Environment.NewLine +
                                    Environment.NewLine +
                                    "Subtotal = -$" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    "HST (13%) = -$" + (float.Parse(wPrice) * 0.13).ToString() + Environment.NewLine +
                                    "Sale Total = -$" + (float.Parse(wPrice) * 1.4 + (float.Parse(wPrice) * 0.13));
                MessageBox.Show(receiptStr, "Order Receipt", MessageBoxButtons.OK);
            }
            else if (updatedStatus == "PAID")
            {
                //make recipt
                db.Update("vehicle", "inStock='NO'", "VIN='" + vin + "'");
                db.Update("CustomerOrder", "OrderStatus='PAID'", "OrderID='" + orderID + "'");


                string receiptStr = "Date: " + date + Environment.NewLine +
                                    "Customer: " + fName + " " + lName + Environment.NewLine +
                                    "OrderID: " + orderID + " - " + updatedStatus + Environment.NewLine +
                                    Environment.NewLine +
                                    year + " " + make + " " + model + ", " + colour + Environment.NewLine +
                                    "VIN: " + vin + " KMS: " + kms + Environment.NewLine +
                                    Environment.NewLine +
                                    "Purchace Price: $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    Environment.NewLine +
                                    "Trade In: N/A" + Environment.NewLine +
                                    Environment.NewLine +
                                    "Subtotal = $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                                    "HST (13%) = $" + (float.Parse(wPrice) * 0.13).ToString() + Environment.NewLine +
                                    "Sale Total = $" + (float.Parse(wPrice) * 1.4 + (float.Parse(wPrice) * 0.13));
                MessageBox.Show(receiptStr, "Order Receipt", MessageBoxButtons.OK);


            }
            else if (updatedStatus == "CANCEL")
            {
                db.Update("vehicle", "inStock='YES'", "VIN='" + vin + "'");
                db.Update("CustomerOrder", "OrderStatus='CANCEL'", "OrderID='" + orderID + "'");

                string receiptStr = "Date: " + date + Environment.NewLine +
                    "Customer: " + fName + " " + lName + Environment.NewLine +
                    "OrderID: " + orderID + " - " + updatedStatus + Environment.NewLine +
                    Environment.NewLine +
                    year + " " + make + " " + model + ", " + colour + Environment.NewLine +
                    "VIN: " + vin + " KMS: " + kms + Environment.NewLine +
                    Environment.NewLine +
                    "Purchace Price: $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                    Environment.NewLine +
                    "Trade In: N/A" + Environment.NewLine +
                    Environment.NewLine +
                    "Subtotal = $" + (float.Parse(wPrice) * 1.4).ToString() + Environment.NewLine +
                    "HST (13%) = $" + (float.Parse(wPrice) * 0.13).ToString() + Environment.NewLine +
                    "Sale Total = $" + (float.Parse(wPrice) * 1.4 + (float.Parse(wPrice) * 0.13));
                MessageBox.Show(receiptStr, "Order Receipt", MessageBoxButtons.OK);
            }
        }
    }
}
