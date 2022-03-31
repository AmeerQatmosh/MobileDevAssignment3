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

            public static void DeleteUser()
            {
                User user1 = new User() { Id = 11923652, Name = "Ahmad", age = 21 };
                User user2 = new User() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                User user3 = new User() { Id = 11934652, Name = "Ahd", age = 30 };
                User user4 = new User() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<User> users = new List<User>();

                List<User> BLibShelf = new List<User>();
                BLibShelf.AddRange(new List<User>() { user1, user2, user3, user4 });

                foreach (var user in BLibShelf)
                {
                    Console.WriteLine("User Details => " + user.ToString());
                }

                Console.WriteLine("Delete user ");
                Console.WriteLine("User id: ");
                var Id = Convert.ToInt32(Console.ReadLine());

               
                for (int i = 0; i < BLibShelf.Count; i++)
                {
                    if (Id == BLibShelf[i].Id)
                    {
                        BLibShelf.RemoveAt(i);
                        Console.WriteLine("user successfully removed! ");
                    }
                }
                foreach (var user in BLibShelf)
                {
                    Console.WriteLine("User Details => " + user.ToString());
                }
            }
        }

        public class AdminUserC : AdminUser
        {
            public AdminUserC(int Id, string Name, int age)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;

            }


            public static void AddAdminUser()
            {

                AdminUser adminuser1 = new AdminUser() { Id = 11923652, Name = "Ahmad", age = 21 };
                AdminUser adminuser2 = new AdminUser() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                AdminUser adminuser3 = new AdminUser() { Id = 11934652, Name = "Ahd", age = 30 };
                AdminUser adminuser4 = new AdminUser() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<AdminUser> users = new List<AdminUser>();

                List<AdminUser> BLibShelf = new List<AdminUser>();
                BLibShelf.AddRange(new List<AdminUser>() { adminuser1, adminuser2, adminuser3, adminuser4 });

                Console.WriteLine("Total " + BLibShelf.Count + " admin users");
                foreach (var adminuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + adminuser.ToString());
                }

                Console.WriteLine("Please input the new admin user Id:");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input the new admin user name:");
                var Name = Console.ReadLine();

                Console.WriteLine("Please input the new admin user age:");
                var age = Convert.ToInt32(Console.ReadLine());
                var newAdminUser = new AdminUserC(Id, Name, age);
                BLibShelf.Add(newAdminUser);

                Console.WriteLine("Total " + BLibShelf.Count + " users");
                foreach (var adminuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + adminuser.ToString());
                }
            }

            public static void DeleteAdminUser()
            {

                AdminUser adminuser1 = new AdminUser() { Id = 11923652, Name = "Ahmad", age = 21 };
                AdminUser adminuser2 = new AdminUser() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                AdminUser adminuser3 = new AdminUser() { Id = 11934652, Name = "Ahd", age = 30 };
                AdminUser adminuser4 = new AdminUser() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<AdminUser> adminusers = new List<AdminUser>();

                List<AdminUser> BLibShelf = new List<AdminUser>();
                BLibShelf.AddRange(new List<AdminUser>() { adminuser1, adminuser2, adminuser3, adminuser4 });

                foreach (var adminuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + adminuser.ToString());
                }

                Console.WriteLine("Delete admin user ");
                Console.WriteLine("Admin User id: ");
                var Id = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < BLibShelf.Count; i++)
                {
                    if (Id == BLibShelf[i].Id)
                    {
                        BLibShelf.RemoveAt(i);
                        Console.WriteLine("admin user successfully removed! ");
                    }
                }
                foreach (var admin in BLibShelf)
                {
                    Console.WriteLine("User Details => " + admin.ToString());
                }

            }
        }






        public class StuffUserC : StuffUser
        {
            public StuffUserC(int Id, string Name, int age)
            {
                this.Id = Id;
                this.Name = Name;
                this.age = age;

            }


            public static void AddStuffUser()
            {

                StuffUser stuffuser1 = new StuffUser() { Id = 11923652, Name = "Ahmad", age = 21 };
                StuffUser stuffuser2 = new StuffUser() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                StuffUser stuffuser3 = new StuffUser() { Id = 11934652, Name = "Ahd", age = 30 };
                StuffUser stuffuser4 = new StuffUser() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<StuffUser> stuffusers = new List<StuffUser>();

                List<StuffUser> BLibShelf = new List<StuffUser>();
                BLibShelf.AddRange(new List<StuffUser>() { stuffuser1, stuffuser2, stuffuser3, stuffuser4 });

                Console.WriteLine("Total " + BLibShelf.Count + " stuff users");
                foreach (var stuffuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + stuffuser.ToString());
                }

                Console.WriteLine("Please input the new stuff user Id:");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please input the new stuff user name:");
                var Name = Console.ReadLine();

                Console.WriteLine("Please input the new stuff user age:");
                var age = Convert.ToInt32(Console.ReadLine());
                var newStuffUser = new StuffUserC(Id, Name, age);
                BLibShelf.Add(newStuffUser);

                Console.WriteLine("Total " + BLibShelf.Count + " stuff users");
                foreach (var stuffuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + stuffuser.ToString());
                }
            }

            public static void DeleteStuffUser()
            {

                StuffUser stuffuser1 = new StuffUser() { Id = 11923652, Name = "Ahmad", age = 21 };
                StuffUser stuffuser2 = new StuffUser() { Id = 11456652, Name = "Ahmadgd", age = 24 };
                StuffUser stuffuser3 = new StuffUser() { Id = 11934652, Name = "Ahd", age = 30 };
                StuffUser stuffuser4 = new StuffUser() { Id = 11923456, Name = "Ahfrgtmad", age = 20 };
                List<StuffUser> stuffusers = new List<StuffUser>();

                List<StuffUser> BLibShelf = new List<StuffUser>();
                BLibShelf.AddRange(new List<StuffUser>() { stuffuser1, stuffuser2, stuffuser3, stuffuser4 });

                foreach (var stuffuser in BLibShelf)
                {
                    Console.WriteLine("User Details => " + stuffuser.ToString());
                }

                Console.WriteLine("Delete stuff user ");
                Console.WriteLine("Stuff User id: ");
                var Id = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < BLibShelf.Count; i++)
                {
                    if (Id == BLibShelf[i].Id)
                    {
                        BLibShelf.RemoveAt(i);
                        Console.WriteLine("stuff user successfully removed! ");
                    }
                }
                foreach (var stuff in BLibShelf)
                {
                    Console.WriteLine("User Details => " + stuff.ToString());
                }

            }



        }




    }
}

