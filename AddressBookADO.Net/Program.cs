using System;

namespace AddressBookADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Problem By ADO.net");
            AddressBookManagment addressBookManagement = new AddressBookManagment();

            addressBookManagement.DataBaseConnection(); //UC1
            Console.ReadLine();
        }
    }
}
