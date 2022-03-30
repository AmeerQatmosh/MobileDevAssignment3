using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exception__Delegate__and_Event_handler.Models
{
    public class AdminUser : User
    {
        public User StuffUser { get; set; }

        /*
        public AdminUser(int Id, string Name, int age,User StuffUser) 
        {
            this.Id = Id;
            this.Name = Name;
            this.age = age;
            this.StuffUser = StuffUser;
        }*/

        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age} - StuffUSer: {this.StuffUser}";
        }

        public override bool Equals(object obj)
        {
           // if (obj == null)
             //   return false;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
