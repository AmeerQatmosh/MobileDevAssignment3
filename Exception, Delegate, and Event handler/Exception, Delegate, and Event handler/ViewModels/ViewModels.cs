using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception__Delegate__and_Event_handler;
using Exception__Delegate__and_Event_handler.Models;

namespace Exception__Delegate__and_Event_handler.ViewModels

{

    class ViewModels
    {
        public class UserViewModel : User
        {
            public UserViewModel(int Id, string Name, int age)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;

            }
            internal static void NewUser()
            {
                List<User> users = new List<User>();

                users.Add(new User());
                Console.WriteLine("Enter user Id: ");
                int _Id = Convert.ToInt32(Console.ReadLine());
                users[0].Id = _Id;
                Console.WriteLine("Enter user Name: ");
                string _Name = Console.ReadLine();
                users[0].Name = _Name;
                Console.WriteLine("Enter user Age: ");
                int _age = Convert.ToInt32(Console.ReadLine());
                users[0].age = _age;

                foreach (User user in users)
                {
                    Console.WriteLine("All user details: ");
                    Console.WriteLine(user.ToString());
                    Console.WriteLine(user.Equals(users));
                }

            }
            internal static void DeleteUser()
            {

            }

        }


        public class AdminUserViewModel : AdminUser
        {
            public AdminUserViewModel(int Id, string Name, int age, User StuffUser)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;
                this.StuffUser = StuffUser;

            }
        }

        public class StuffUserViewModel : StuffUser
        {
            public StuffUserViewModel(int Id, string Name, int age, string role)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;
                this.role = role;

            }
        }

    }
    
}

