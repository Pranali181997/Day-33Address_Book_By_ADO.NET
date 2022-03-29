using System;

namespace AddressBookADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Problem By ADO.net");
            while (true)
            {
                Console.WriteLine("Select Number \n 1.Create A Database \n 2. Create Data Base Table \n 3.Inserting Data");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookManagment.CreateDataBase();
                        break;
                    case 2:
                        AddressBookManagment.CreateTable();
                        break;
                    case 3:
                        AddressBookManagment address = new AddressBookManagment();
                        AddressBookModel emp = new AddressBookModel();

                        emp.FirstName = "Pranali";
                        emp.LastName = "Lambat";
                        emp.State = "Maha";
                        emp.City = "Nag";
                        emp.PhoneNumber = 586223;
                        emp.AddressBookName = "AddressBookTable";
                        emp.AddressBookType = "DataBook";
                        emp.Address = "Dighori";
                        emp.EmailId = "Pranali@gmail.com";
                        emp.Zip = "55226";
                        address.InsertedData(emp);
                        break;
                    default:
                        Console.WriteLine("The option is incorrect");
                        break;
                    
                }
            }
        
        }
    }
}
