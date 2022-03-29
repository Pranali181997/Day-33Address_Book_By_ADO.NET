using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO.Net
{
    public class AddressBookManagment
    {
        /* UC1:- Address Book ServiceDB
                      - Use SQL Client to create DB and DB Records.
             */
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);

        public void DataBaseConnection()
        {
            try
            {
                DateTime now = DateTime.Now;
                connection.Open();
                using (connection)
                {
                    Console.WriteLine($"Connection is created Successful {now}");

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}