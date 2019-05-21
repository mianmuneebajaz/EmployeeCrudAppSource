using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsersCrudApp.WebUI.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; } 
        public string About { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; } 
        public double Salary { get; set; }
    }
}