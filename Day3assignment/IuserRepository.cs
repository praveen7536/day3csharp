using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Day3assignment
{
    public interface IuserRepository
    {
        public List<User> Users();
        public User GetUser(int id);
        public List<User> DeleteUser(int id);
        public List<User> ActiveUser();
        public List<User> AddUser(User user);




    }
}
