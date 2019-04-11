/*
 * FILE          : ConnectDB.cs
 * PROJECT       : Assignment 4 RD - PROG2110
 * PROGRAMMER    : Billy Parmenter
 * FIRST VERSION : November 30, 2018
 * DESCRIPTION   : This class is for connecting to the database and
 *                  issue MySql commands
 */

using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace RD_A4
{
    class ConnectDB
    {
        private readonly MySqlConnection connect;       // The open connection to the database
        private readonly string server = "127.0.0.1";   // The ip to connect to
        private readonly string dB = "Wally";         // The name of the database to be used
        private readonly string userName = "root";      // The user for connecting to the database
        private readonly string password = "password";  // The password for the user above





        // Class constructor
        public ConnectDB()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + dB + ";" +
                                      "UID=" + userName + ";" + "PASSWORD=" + password + ";";

            connect = new MySqlConnection(connectionString);
        }




        /*
         * FUNCTION    : ConnectToDB
         * DESCRIPTION : Try to connect to the database, if there is an issue then throw an exception
         *                  and display an error message
         * PARAMETERS  : NONE
         * RETURNS     : NONE
         */
        public bool ConnectToDB()
        {
            try
            {
                connect.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Cannot connect to server.  Contact admin", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }





        /*
         * FUNCTION    : DisconnectFromDB
         * DESCRIPTION : Close the connection to the database
         * PARAMETERS  : NONE
         * RETURNS     : NONE
         */
        private void DisconnectFromDB()
        {
            connect.Close();
        }





        /*
         * FUNCTION    : Insert
         * DESCRIPTION : Used for inserting into the database
         * PARAMETERS  : string table   : The table to insert into
         *               string columns : The columns to insert into 
         *               string values  : The values to be inserted
         * RETURNS     : NONE
         */
        public void Insert(string table, string columns, string values)
        {
            string query = "INSERT INTO " + table + " (" + columns +") VALUES(" + values + ")";

            //open connection, send the command, then close the connection
            if (this.ConnectToDB() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);

                cmd.ExecuteNonQuery();

                this.DisconnectFromDB();
            }
        }





        /*
         * FUNCTION    : Update
         * DESCRIPTION : Used for updating a table in the database
         * PARAMETERS  : string table : The table to update
         *               string set   : The columns to update
         *               string where : The row(s) to be updated
         * RETURNS     : NONE
         */
        public void Update(string table, string set, string where)
        {
            string query = "UPDATE " + table + " SET " + set + " WHERE " + where;

            //Open connection, send the command, close the connection
            if (this.ConnectToDB() == true)
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    CommandText = query,

                    Connection = connect
                };

                cmd.ExecuteNonQuery();

                this.DisconnectFromDB();
            }
        }





        /*
         * FUNCTION    : Select
         * DESCRIPTION : Used for geting rows from a table in the database
         * PARAMETERS  : string select : The columns to return
         *               string table  : The table to search
         * RETURNS     : List<List<string>> : Contains the values gotten from the database
         */
        public List<List<string>> Select(string select, string table)
        {
            string query = "SELECT " + select + " FROM " + table + ";";

            //Create a list to store the result
            List<List<string>> results = new List<List<string>> ();

            //Open connection, send the command and close the connection
            if (this.ConnectToDB() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);

                //Data reader to read what the database sends back
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                int i = 0;
                while (dataReader.Read())
                {
                    results.Add(new List<string>());

                    for (int j = 0; j < dataReader.FieldCount; j++)
                    {
                        results[i].Add(dataReader.GetString(j));
                    }
                    i++;
                }

                dataReader.Close();

                this.DisconnectFromDB();

                return results;
            }
            else
            {
                return results;
            }
        }
    }
}
