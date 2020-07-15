﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Day3assignment
{
    class UserRepository : User, IuserRepository
    {
        public int userid = 1;
        private List<User> users = new List<User>();

        //constructor
        public UserRepository()
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    users.Add(new User()
                    {
                        Id = userid,
                        Name = "Praveen" + i,
                        Email = "prav" + i + "@gmail.com",
                        Location = "Blgr" + i,
                        Address = "street" + i,
                        Isactive = 1
                    });
                    userid++;
                }
                else
                {
                    users.Add(new User()
                    {
                        Id = userid,
                        Name = "Praveen" + i,
                        Email = "prav" + i + "@gmail.com",
                        Location = "Blgr" + i,
                        Address = "street" + i,
                        Isactive = 0
                    });
                    userid++;

                }
            }
        }
        public List<User> Users()
        {
            return users;
        }
        public User GetUser(int id)
        {
            var user1 = users.Where(a => a.Id == id).FirstOrDefault();
            return user1;
        }
        public List<User> DeleteUser(int id)
        {
            var remove = users.Where(a => a.Id == id).FirstOrDefault();
            if(remove==null)
            {
                Console.WriteLine("No users Found");
            }
            else
            {
                users.Remove(remove);
            }
            return users;

        }
        public List<User> ActiveUser()
        {
            List<User> active = new List<User>();
            foreach (var item in users)
            {
                if(item.Isactive==1)
                {
                    active.Add(item);
                }
            }
            return active;

        }
        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

    }
}




