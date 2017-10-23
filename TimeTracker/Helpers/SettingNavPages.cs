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
        public static string Projects => "Projects";
        public static string Teams => "Teams";
        public static string TaskDefaultValue => "TaskDefaultValue";
        
        public static string IndexNavClass(ViewContext viewContext) => BaseNavPages.PageNavClass(viewContext, Index);
        public static string ProjectsNavClass(ViewContext viewContext) => BaseNavPages.PageNavClass(viewContext, Projects);
        public static string TeamsNavClass(ViewContext viewContext) => BaseNavPages.PageNavClass(viewContext, Teams);
        public static string TaskDefaultValueNavClass(ViewContext viewContext) => BaseNavPages.PageNavClass(viewContext, TaskDefaultValue);
    }
}
