using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Exception__Delegate__and_Event_handler.Models;
using Exception__Delegate__and_Event_handler.ViewModels;

namespace Exception__Delegate__and_Event_handler
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            while (true)
            {
                
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("  To perform the following operations. choose the operation number.");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("  [1] Add User.                                                    ");
                Console.WriteLine("  [2] Edit User.                                                   ");
                Console.WriteLine("  [3] Delete User.                                                 ");
                Console.WriteLine("  [4] Display Users List.                                          ");
                Console.WriteLine("-------------------------------------------------------------------");


                Console.WriteLine("Enter your choice: ");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("  To perform the following operations. choose the operation number.");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("[1] Add user                                                       ");
                        Console.WriteLine("[2] Add Adminuser                                                  ");
                        Console.WriteLine("[3] Add Stuffuser                                                  ");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Enter your choice: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        if ( choice == 1)
                        {
                            Console.WriteLine("-------------------------- Add User -------------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.UserC.AddUser();
                        }
                        if ( choice == 2)
                        {
                            Console.WriteLine("----------------------- Add AdminUser -----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.AdminUserC.AddAdminUser();

                        }
                        if (choice == 3)
                        {
                            Console.WriteLine("------------------------ Add StuffUser ----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.StuffUserC.AddStuffUser();
                        }



                        break;

                    case 2:
                        
                        break;
                        
                    case 3:
                        break;

                    case 4:
                        break;
                        

                    default:
                        Console.WriteLine("*Unknown choice, Please try again! ");
                        break;
                }
            }

        }

        
            
    }
}























