using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpEx
{
    internal class UserList
    {
        public List<User> Users { get; private set; }
        public UserList() 
        {
            this.Users = new List<User>();
            FillList();
        }
        private void FillList()
        {
            Users.Add(new User("Yossi", "1234"));
            Users.Add(new User("Blabla", "15324"));
            Users.Add(new User("wagta", "6237"));
        }
        public class UsersService
        {
            public UsersService()
            {
                
            }
        }
    }
}
