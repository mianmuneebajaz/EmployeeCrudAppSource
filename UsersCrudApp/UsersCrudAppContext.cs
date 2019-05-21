 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCrudApp.UsersMgt;

namespace UsersCrudApp
{
    public class UsersCrudAppContext : DbContext
    { 
        public UsersCrudAppContext()
           : base("Server= localhost; Database= UsersCrudApp;user id=sa;password=123")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; } 

        
    }
}
