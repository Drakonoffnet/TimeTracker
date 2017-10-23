using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Helpers
{
    public static class SettingNavPages
    {
        public static string Index => "Index";
        public static string IndexNavClass(ViewContext viewContext) => BaseNavPages.PageNavClass(viewContext, Index);
    }
}
