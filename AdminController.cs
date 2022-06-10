using student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace student_management.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        studentEntities db = new studentEntities();
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(admin admchk)
        {


            if (ModelState.IsValid)
            {
                using (studentEntities db = new studentEntities())
                {

                    var obj = db.admins.Where(a => a.username.Equals(admchk.username) && a.password.Equals(admchk.password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["UserID"] = obj.id.ToString();
                        Session["UserName"] = obj.username.ToString();
                        return RedirectToAction("UserDashboard");


                    }

                    else
                    {

                        ModelState.AddModelError("", "The UserName or Password Incorrect");



                    }


                }


            }

            return View(admchk);
        }

        public ActionResult UserDashboard()
        {
            if (Session["UserID"] != null)
            {
                return View("UserDashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}