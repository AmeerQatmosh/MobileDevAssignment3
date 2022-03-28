using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Delegate__and_Event_handler.Models
{
    internal class AdminUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public User StuffUser { get; set; }

        public AdminUser(int Id, string Name, int age, User StuffUser)
        {
            this.Id = Id;
            this.Name = Name;
            this.age = age;
            this.StuffUser = StuffUser;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age} - StuffUSer: {this.StuffUser}";
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
