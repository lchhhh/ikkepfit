using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikeepfit.IServices;
using ikeepfit.Services;
using ikeepfit.Model;
using ikeepfit.Repository;
using ikeepfit.IRepository;
using ikeepfit.WebCore;

namespace ikeepfit.web.Controllers
{
    public class HomeController : BaseController
    {
        IPlanServices planservices;

      
        public HomeController(IPlanServices plans)
        {
            this.planservices = plans;
        }
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult plan_menu()
        {
            ViewBag.controllername = RouteData.Values["controller"].ToString().ToLower();
            ViewBag.planlist = planservices.QueryWhere(a => true).OrderByDescending(a => a.mt_plan_id);
            return View();
        }
        public ActionResult plan_menu_add()
        {
            return View();
        }
        public ActionResult course_menu()
        {
            return View();
        }
      
        public ActionResult book_menu()
        {
            return View();
        }
        public ActionResult knowledge_menu()
        {
            return View();
        }
        public ActionResult food_menu()
        {
            return View();
        }


        
    }
}