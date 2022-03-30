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

                Console.WriteLine("[1] Add User.");
                Console.WriteLine("[2] Edit User. ");
                Console.WriteLine("[3] Delete User. ");
                Console.WriteLine("[4] Exit.");

                Console.WriteLine("*Enter your choice! ");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ViewModels.ViewModels.UserViewModel.NewUser();
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        Console.WriteLine("*Press any button to exit the application! ");
                        break;

                    case 4:
                        Console.WriteLine("*Press any button to exit the application! ");
                        return;

                    default:
                        Console.WriteLine("*Unknown choice, Please try again! ");
                        break;
                }
            }

        }
    

    }
}























