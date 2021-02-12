using CRUDEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDEntityFramework.Config
{
    public static class SettingsParam
    {
        public static DialogResultData data { set; get; }
        public static int? IdDeleted { get; set; }
        public static DialogResultData UpdatedData { get; set; }
    }
}
