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
                
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("  To perform the following operations. choose the operation number. ");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("  [1] Add Users.                                                    ");
                Console.WriteLine("  [2] Delete Users.                                                 ");
                Console.WriteLine("  [3] Edit Users.                                                   ");
                Console.WriteLine("  [4] Exit.                                                         ");
                Console.WriteLine("--------------------------------------------------------------------");


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
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("-------------------------- Add User -------------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.UserC.AddUser();
                        }
                        if ( choice == 2)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("----------------------- Add AdminUser -----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.AdminUserC.AddAdminUser();

                        }
                        if (choice == 3)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("------------------------ Add StuffUser ----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.StuffUserC.AddStuffUser();
                        }
                        break;

                    case 2:
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("  To perform the following operations. choose the operation number.");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("[1] Delete user                                                    ");
                        Console.WriteLine("[2] Delete Adminuser                                               ");
                        Console.WriteLine("[3] Delete Stuffuser                                               ");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Enter your choice: ");
                        int removeChoice = Convert.ToInt32(Console.ReadLine());

                        if (removeChoice == 1)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("----------------------- Remove User -------------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.UserC.DeleteUser();
                        }
                        if (removeChoice == 2)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("-------------------- Remove AdminUser -----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.AdminUserC.DeleteAdminUser();

                        }
                        if (removeChoice == 3)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("--------------------- Remove StuffUser ----------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.StuffUserC.DeleteStuffUser();
                        }
                        break;
                        
                    case 3:
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("  To perform the following operations. choose the operation number.");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("[1] Edit user                                                      ");
                        Console.WriteLine("[2] Edit Adminuser                                                 ");
                        Console.WriteLine("[3] Edit Stuffuser                                                 ");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Enter your choice: ");
                        int EditChoice = Convert.ToInt32(Console.ReadLine());

                        if (EditChoice == 1)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("-------------------------- Edit User ------------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.UserC.EditUser();
                        }
                        if (EditChoice == 2)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("------------------------ Edit AdminUser ---------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.AdminUserC.EditAdminUser();

                        }
                        if (EditChoice == 3)
                        {
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("-------------------------- Edit StuffUser -------------------------");
                            Console.WriteLine("-------------------------------------------------------------------");
                            ViewModels.ViewModels.StuffUserC.EditStuffUser();
                        }

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























