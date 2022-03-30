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

                Console.WriteLine("*Enter your choice! ");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddUser.addUser();
                        break;

                    case 2:
                        Console.WriteLine("*Press any button to exit the application! ");
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
        class AddUser
        {
            public static void addUser()
            {


                int Id;
                string Name;
                int age;
                Console.WriteLine("Enter User Id: ");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter User Name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter User Age: ");
                age = Convert.ToInt32(Console.ReadLine());


                Class1 newUser = new Class1();
                newUser.AddNewUser(Id, Name, age);

                Console.WriteLine("--------------------------");
                Console.WriteLine("User is successfully added!");
                Console.WriteLine("User id is: " + Id);
                Console.WriteLine("User Name is: " + Name);
                Console.WriteLine("User Age is: " + age);
                Console.WriteLine("--------------------------");
 
            }


        }    

    }
}























