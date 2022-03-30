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
        int newId;
        string newName;
        int newAge;

        public void AddNewUser(int Id, string Name, int age)
        {
                newId = Id;
                newName = Name;
                newAge = age;

                Console.WriteLine(newId + newAge + newName);

        }

        public void UpdateUser (int Id)
        {

        }
    }
}

