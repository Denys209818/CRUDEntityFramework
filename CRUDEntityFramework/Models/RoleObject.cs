using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDEntityFramework.Models
{
    public class RoleObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
