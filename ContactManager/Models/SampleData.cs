using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public static class SampleData
    {
        static Contact[] sampleContacts = new Contact[]
            {
                new Contact { ContactId = 1, FirstName = "Glenn", LastName="Block", Email = "gblock@microsoft.com", PhoneNumber="1111111111", Status="Active" },
                new Contact { ContactId = 2, FirstName = "Howard", LastName = "Dierking", Email = "howard@microsoft.com", PhoneNumber = "222-222-2222", Status = "Active" },
                new Contact { ContactId = 3, FirstName = "Yavor", LastName = "Georgiev",  Email = "yavorg@microsoft.com", PhoneNumber = "3333333333", Status = "Inactive" },
                new Contact { ContactId = 4, FirstName = "Jeff", LastName = "Handley",  Email = "jeff.handley@microsoft.com", PhoneNumber = "4444444444", Status = "Active" },
                new Contact { ContactId = 5, FirstName = "Daniel", LastName = "Roth", Email = "daroth@microsoft.com", PhoneNumber = "555-555-5555", Status = "Active" }
            };

        public static Contact[] Contacts
        {
            get
            {
                return sampleContacts;
            }
        }
    }
}