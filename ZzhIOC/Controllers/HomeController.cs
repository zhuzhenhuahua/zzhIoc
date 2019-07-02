using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZzhIOC.Controllers
{
    public class HomeController : Controller
    {
        public ITaskRepository taskRepository { get; set; }
        public ActionResult Index()
        {
            //加个注释
            string s = taskRepository.writeTask();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
