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
        public static void CreateTable()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBookService;Integrated Security=True");
            
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("create table AddressBookTable(EmpId int Identity(1,1)Primary key,FirstName varchar (50),LastName varchar(50),Address varchar(50),City varchar(50),State varchar(50),Zip varchar(50),PhoneNumber BIGINT,AddressBookName varchar(50),AddressBookType varchar(50),EmailId varchar(50))", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Address Book Table Created Successfully");
            }
            catch (Exception ex)
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