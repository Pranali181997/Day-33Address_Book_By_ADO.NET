using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookADO.Net
{
    public class AddressBookModel
    {
        /*UC1:- Address Book ServiceDB
           - Use SQL Client to create DB and DB Records
        */
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }
        public string EmailId { get; set; }
        
    }
}
