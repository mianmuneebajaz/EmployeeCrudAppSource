using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsersCrudApp.UsersMgt
{
    public class UsersHandler
    {
        public User AddUser(User u)
        {
            try
            {

                if (u.Id != 0)
                    return null;
                using (UsersCrudAppContext con = new UsersCrudAppContext())
                {
                    con.Users.Add(u);
                    con.SaveChanges();
                    return u;
                }
            }
            catch { return null; }
        }
        public User RemoveUser(int uid)
        {
            try
            {
                if (uid == 0)
                    return null;
                using (UsersCrudAppContext con = new UsersCrudAppContext())
                {
                    var user = con.Users.Find(uid);
                    con.Users.Remove(user);
                    con.SaveChanges();
                    return user;
                }
            }
            catch { return null; }
        }

        public User GetUser(int id)
        {
            using (UsersCrudAppContext con = new UsersCrudAppContext())
            {
                return
                    (from u in con.Users
                     where u.Id == id
                     select u).FirstOrDefault();
            }
        }

        public User UpdateUser(int id, User u)
        {
            try
            {
                using (UsersCrudAppContext con = new UsersCrudAppContext())
                {
                    var user = con.Users.Find(id);
                    user.FullName = u.FullName;
                    user.Address = u.Address;
                    user.About = u.About;
                    user.CNIC = u.CNIC;
                     
                    user.PhoneNumber = u.PhoneNumber;
                    user.Salary = u.Salary;
                    con.SaveChanges();
                    return user;
                }
            }
            catch { return null; }
        }
        public IEnumerable<User> GetUsers()
        {
            using (UsersCrudAppContext con = new UsersCrudAppContext())
            { 
                return con.Users
                .OrderBy(c => c.FullName)
                .ToList();
            }
        }

    }
}
