using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Delegate__and_Event_handler.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }       

        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            User objAsUser = obj as User;
            if (objAsUser == null)
            {
                return false;
            }
            else return Equals(objAsUser);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}

   
