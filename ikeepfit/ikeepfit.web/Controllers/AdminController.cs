using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikeepfit.IServices;
using ikeepfit.Model;

namespace ikeepfit.web.Controllers
{
    public class AdminController : Controller
    {
        IAdminServices adminservices;


        public AdminController(IAdminServices admins)
        {
            this.adminservices = admins;
        }
        // GET: Admin

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="returnUrl">返回Url</param>
        /// <returns></returns>
        public ActionResult Login()
        {
            var model = new mt_admin();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(mt_admin model)
        {
            var db = new ikeepfitEntities1();
            var entity = db.mt_admin.Where(w => w.username == model.username).FirstOrDefault();
            if (entity == null)
            {
                model.Message = "用户名不存在";
            }
            else
            {
                if (entity.password != model.password)
                {
                    model.Message = "密码输入不正确";
                } 
                else
                {
                    return RedirectToAction("Index", "Home", new { });
                }
            }

            return View(model);
        }
    }
}

