﻿using System;

namespace AddressBookADO.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Problem By ADO.net");
            while (true)
            {
                Console.WriteLine("Select Number \n 1.Create A Database");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookManagment.CreateDataBase();
                        break;
                    default:
                        Console.WriteLine("The option is incorrect");
                        break;
                }
            }
        
        }
    }
}
