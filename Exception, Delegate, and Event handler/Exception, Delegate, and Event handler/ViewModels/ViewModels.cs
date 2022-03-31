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
        public class UserC : User
        {
            public UserC(int Id, string Name, int age)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;

            }


            public static void AddUser()
            {

                User user1 = new User() { Id = 11923652, Name = "Ahmad", age = 21 };
                User user2 = new User() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                User user3 = new User() { Id = 11934652, Name = "Ahd", age = 30 };
                User user4 = new User() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<User> users = new List<User>();

                List<User> BLibShelf = new List<User>();
                BLibShelf.AddRange(new List<User>() { user1, user2, user3, user4 });

                Console.WriteLine("Total " + BLibShelf.Count + " users");
                foreach (var user in BLibShelf)
                {
                    Console.WriteLine("User Details => " + user.ToString());
                }

                Console.WriteLine("Please input the new user Id:");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input the new user name:");
                var Name = Console.ReadLine();

                Console.WriteLine("Please input the new user age:");
                var age = Convert.ToInt32(Console.ReadLine());
                var newUser = new UserC(Id, Name, age);
                BLibShelf.Add(newUser);

                Console.WriteLine("Total " + BLibShelf.Count + " users");
                foreach (var user in BLibShelf)
                {
                    Console.WriteLine("User Details => " + user.ToString());
                }


            }
        }
    }
}
 /*       
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
    
*/

