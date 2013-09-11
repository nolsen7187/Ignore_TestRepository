using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCrudTest1.Models
{
    public class Contact
    {
        [Required]
        public Int32 ID { get; set; }
        [Required]
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        [Required]
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State {get; set; }
        public String Zip {get; set;}
        public String Country {get; set;}
    }

    public class DBContact : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}