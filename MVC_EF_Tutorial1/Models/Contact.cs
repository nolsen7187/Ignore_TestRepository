using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_EF_Tutorial1.Models
{
    public class Contact
    {
        [Required]
        public Int32 Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }

    }
    public class DbContact : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}