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

namespace ikeepfit.web.Controllers
{
    public class HomeController : Controller
    {
        IPlanServices planservices = new PlanServices();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult plan_menu()
        {
            try
            {
                //var usreinfo = userinfoservice.QueryWhere(c => c.uID > 2).FirstOrDefault();
                for (int i = 0; i < 10; i++)
                {
                    planservices.Add(new mt_plan()
                    {
                        mt_plan_id="2"+i,
                        mt_plan_name = "测试",
                        mt_plan_title = "超级管理员",
                        mt_plan_remarks = "测试",
                        mt_plan_week = 5,
                        mt_plan_day = 5,
                        mt_plan_strength = "2"
                    });
                }

                planservices.SaverChanges();
                return Content("添加数据成功");
            }
            catch (Exception ex)
            {

                return Content("错误提示：" + ex.Message); ;
            }
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