using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersCrudApp.UsersMgt
{
    public class User
    {
        public User()
        {

        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        
        public string About { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; } 
        public double Salary { get; set; }
    }
}
