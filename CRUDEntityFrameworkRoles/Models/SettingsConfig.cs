using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDEntityFrameworkRoles.Models
{
    public static class SettingsConfig
    {
        public static CreateModelElement createModelElement { get; set; }
        public static int DeletedId { get; set; }
        public static UpdateModelElement UpdateElement { get; set; }
    }
}
