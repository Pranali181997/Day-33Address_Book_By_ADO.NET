using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO.Net
{
    public class AddressBookManagment
    {
        public static void CreateDataBase()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create DataBase AddressBookService", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Address Book Created Successfully");               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured by Connection Database while creating DB");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}