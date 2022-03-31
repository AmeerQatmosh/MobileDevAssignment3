using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Delegate__and_Event_handler.Models
{
    internal class StuffUser : User
    {
        [Flags]
        public enum Role
        {
            Role1,
            Role2,
            Role3,
        }
        public Role role  { get; set; }
    
        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age} - role: {this.role}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            StuffUser objAsStuffUser = obj as StuffUser;
            if (objAsStuffUser == null)
            {
                return false;
            }
            else return Equals(objAsStuffUser);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(StuffUser other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }


    }
}
