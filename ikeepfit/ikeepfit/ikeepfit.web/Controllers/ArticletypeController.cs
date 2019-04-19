using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikeepfit.Model;
using ikeepfit.IServices;
using ikeepfit.Services;
using ikeepfit.Repository;
using ikeepfit.IRepository;

namespace ikeepfit.web.Controllers
{
    public class ArticletypeController : Controller
    {
        // GET: Articletype
   
            IArticletypeServices articleservices;


            public ArticletypeController(IArticletypeServices articletypes)
            {
                this.articleservices = articletypes;
            }
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult articletype_menu()
            {

                ViewBag.controllername = RouteData.Values["controller"].ToString().ToLower();
                ViewBag.articletypelist = articleservices.QueryWhere(a => true).OrderByDescending(a => a.mt_articletype_id);
                return View();
            }
            public ActionResult articletype_menu_add()
            {
                return View();
            }

        
    }
}