using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Delegate__and_Event_handler.Models
{
    internal class StuffUser: User
    { 
        public string role { get; set; }

        /*
        public StuffUser(int Id, string Name, int age, string role)
        {
            this.Id = Id;
            this.Name = Name;
            this.age = age;
            this.role = role;
        }
        */
     
    
        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age} - role: {this.role}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
