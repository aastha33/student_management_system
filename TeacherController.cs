using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using student_management.Models;

namespace student_management.Controllers
{
    public class TeacherController : Controller
    {
        private studentEntities db = new studentEntities();

        // GET: Teacher
        public ActionResult Index()
        {
            var teachers = db.teachers.Include(t => t.course).Include(t=>t.branch).Include(t => t.registration);
            return View(teachers.ToList());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            ViewBag.courseid = new SelectList(db.courses, "id", "course1");
            ViewBag.batchid = new SelectList(db.branches, "id", "batch");
            ViewBag.registrationid = new SelectList(db.registrations, "id", "firstname");
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,firstname,lastname,courseid,batchid,registrationid,telno")] teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseid = new SelectList(db.courses, "id", "course1", teacher.courseid);
            ViewBag.batchid = new SelectList(db.branches, "id", "batch", teacher.batchid);
            ViewBag.registrationid = new SelectList(db.registrations, "id", "firstname", teacher.registrationid);
            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseid = new SelectList(db.courses, "id", "course1", teacher.courseid);
            ViewBag.batchid = new SelectList(db.branches, "id", "batch", teacher.batchid);
            ViewBag.registrationid = new SelectList(db.registrations, "id", "firstname", teacher.registrationid);
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,firstname,lastname,courseid,batchid,registrationid,telno")] teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseid = new SelectList(db.courses, "id", "course1", teacher.courseid);
            ViewBag.batchid = new SelectList(db.branches, "id", "batch", teacher.batchid);
            ViewBag.registrationid = new SelectList(db.registrations, "id", "firstname", teacher.registrationid);
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teacher teacher = db.teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            teacher teacher = db.teachers.Find(id);
            db.teachers.Remove(teacher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
