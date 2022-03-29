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
                Console.WriteLine("Select Number \n 1.Create A Database \n 2. Create Data Base Table \n 3.Inserting Data \n 4.Update Record \n 5.Delete Contact By User Name Contact");
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

                        emp.FirstName = "swaroop";
                        emp.LastName = "giri";
                        emp.State = "maha";
                        emp.City = "mumbai";
                        emp.PhoneNumber = 5864223;
                        emp.AddressBookName = "AddressBook";
                        emp.AddressBookType = "DataBook";
                        emp.Address = "parel";
                        emp.EmailId = "ali@gmail.com";
                        emp.Zip = "557226";
                        address.InsertedData(emp);
                        break;
                    case 4:
                        AddressBookManagment address1 = new AddressBookManagment();
                        AddressBookModel emp1 = new AddressBookModel();

                        emp1.FirstName = "Mahi";
                        emp1.LastName = "giri";
                        emp1.State = "maha";
                        emp1.City = "mumbai";
                        emp1.PhoneNumber = 5864223;
                        emp1.AddressBookName = "AddressBook";
                        emp1.AddressBookType = "DataBook";
                        emp1.Address = "parel";
                        emp1.EmailId = "ali@gmail.com";
                        emp1.Zip = "557226";
                        address1.InsertedData(emp1);

                        address1.UpdateContact(emp1);
                        break;
                        case 5:
                        AddressBookManagment address2 = new AddressBookManagment();
                        AddressBookModel emp2 = new AddressBookModel();

                        emp2.FirstName = "Mahi";
                        emp2.LastName = "giri";
                        emp2.State = "maha";
                        emp2.City = "mumbai";
                        emp2.PhoneNumber = 5864223;
                        emp2.AddressBookName = "AddressBook";
                        emp2.AddressBookType = "DataBook";
                        emp2.Address = "parel";
                        emp2.EmailId = "ali@gmail.com";
                        emp2.Zip = "557226";
                        address2.InsertedData(emp2);

                        address2.deleteContact(emp2);
                        
                        break;


                    default:
                        Console.WriteLine("The option is incorrect");
                        break;                   
                }
            }
        
        }
    }
}
