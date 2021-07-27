using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orAdminLTE.Controllers
{
    public class AdminLTEController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentMenu = "Index";
            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.CurrentMenu = "Index2";
            return View();
        }

        public IActionResult Index3()
        {
            ViewBag.CurrentMenu = "Index3";
            return View();
        }
        
        public IActionResult Widgets()
        {
            ViewBag.CurrentMenu = "Widgets";
            return View();
        }

        public IActionResult ChartJS()
        {
            ViewBag.CurrentMenu = "ChartJS";
            return View();
        }

        public IActionResult ChartFlot()
        {
            ViewBag.CurrentMenu = "ChartFlot";
            return View();
        }

        public IActionResult ChartInline()
        {
            ViewBag.CurrentMenu = "ChartInline";
            return View();
        }

        public IActionResult ChartUPlot()
        {
            ViewBag.CurrentMenu = "ChartUPlot";
            return View();
        }

        public IActionResult UIGeneral()
        {
            ViewBag.CurrentMenu = "UIGeneral";
            return View();
        }

        public IActionResult UIIcons()
        {
            ViewBag.CurrentMenu = "UIIcons";
            return View();
        }

        public IActionResult UIButtons()
        {
            ViewBag.CurrentMenu = "UIButtons";
            return View();
        }

        public IActionResult UISliders()
        {
            ViewBag.CurrentMenu = "UISliders";
            return View();
        }

        public IActionResult UIModals()
        {
            ViewBag.CurrentMenu = "UIModals";
            return View();
        }

        public IActionResult UINavbar()
        {
            ViewBag.CurrentMenu = "UINavbar";
            return View();
        }

        public IActionResult UITimeline()
        {
            ViewBag.CurrentMenu = "UITimeline";
            return View();
        }

        public IActionResult UIRibbons()
        {
            ViewBag.CurrentMenu = "UIRibbons";
            return View();
        }

        public IActionResult Starter()
        { 
            return View();
        }
    }
}
