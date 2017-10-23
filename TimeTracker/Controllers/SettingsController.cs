using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracker.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region project

        public IActionResult Projects()
        {
            return View();
        }
        
        #endregion

        #region Teams

        public IActionResult Teams()
        {
            return View();
        }

        #endregion

        #region TaskDefaultValue

        public IActionResult TaskDefaultValue()
        {
            return View();
        }

        #endregion
    }
}