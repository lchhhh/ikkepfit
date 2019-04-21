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
        //叉
        public ActionResult plan_menu()
        {
            ViewBag.controllername = RouteData.Values["controller"].ToString().ToLower();
            ViewBag.planlist = planservices.QueryWhere(a => true).OrderByDescending(a => a.mt_plan_id);
            return View();
        }
        //增
        public ActionResult plan_menu_add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult plan_menu_add(mt_plan plan)
        {
            try
            {
                mt_plan mt_plan = new mt_plan();
                planservices.Add(plan);
                planservices.SaverChanges();
                return Content("添加成功");
            }
            catch (Exception)
            {
                return Content("提交失败");
            }
        }

        //删
        [HttpPost]
        public ActionResult plan_menu_delete(string id)
        {
            mt_plan mt_plan = new mt_plan() { mt_plan_id=id};
            planservices.Delete(mt_plan, false);
            planservices.SaverChanges();
            return Content("删除成功");
        }

        //改
        [HttpGet]
        public ActionResult plan_menu_edit(string id)
        {
            mt_plan mt_plan = new mt_plan() { mt_plan_id = id };
            return View(mt_plan);
        }
        [HttpPost]
        public ActionResult plan_menu_edit(mt_plan plan,string id)
        {
            try
            {
                mt_plan mt_plan = new mt_plan() { mt_plan_id=id};
                planservices.Edit(plan);
                planservices.SaverChanges();
                return Content("添加成功");
            }
            catch (Exception)
            {
                return Content("提交失败");
            }
        }
    }
}