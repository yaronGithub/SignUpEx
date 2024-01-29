using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpEx.Service
{
    public class UserList
    {
        public List<User> Users { get; set; }
        public UserList()
        {
            Users = new List<User>();
            FillList();
        }
        private void FillList()
        {
            Users.Add(new User("Yossi", "1234"));
            Users.Add(new User("Blabla", "15324"));
            Users.Add(new User("wagta", "6237"));
        }
    }
    public class UsersService
    {
        List<User> users;
        public UsersService()
        {
            users = new UserList().Users;
        }
        public bool Login(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
