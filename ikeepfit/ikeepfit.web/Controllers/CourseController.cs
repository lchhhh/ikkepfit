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
    public class CourseController : BaseController
    {
        ICourseServices courseservices;
        // GET: Course

        public CourseController(ICourseServices courses)
        {
            this.courseservices = courses;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult course_menu()
        {

            ViewBag.controllername = RouteData.Values["controller"].ToString().ToLower();
            ViewBag.courselist = courseservices.QueryWhere(a => true).OrderByDescending(a => a.mt_course_id);
            return View();
        }
        public ActionResult course_menu_add()
        {
            return View();
        }
      
    }
}