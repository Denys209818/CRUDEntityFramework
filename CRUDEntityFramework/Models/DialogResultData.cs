using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUDEntityFramework.Models
{
    public class DialogResultData 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public RoleObject Role { get; set; }
    }
}
