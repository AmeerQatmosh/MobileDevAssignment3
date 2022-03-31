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

        public override string ToString()
        {
            return $"Id: {this.Id} - Name: {this.Name} - age: {this.age} - StuffUSer: {this.StuffUser}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            AdminUser objAsAdminUser = obj as AdminUser;
            if (objAsAdminUser == null)
            {
                return false;
            }
            else return Equals(objAsAdminUser);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(AdminUser other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }

    }
}
