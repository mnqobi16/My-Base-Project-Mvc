using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewPSL.Data;
using NewPSL.Models.PSL;

namespace NewPSL.Controllers
{
    public class Customer_PurchaseController : Controller
    {
        private PSLContext db = new PSLContext();

        // GET: Customer_Purchase
        public ActionResult Index()
        {
            var customer_Purchase = db.Customer_Purchase.Include(c => c.Employee);
            return View(customer_Purchase.ToList());
        }

        // GET: Customer_Purchase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Purchase customer_Purchase = db.Customer_Purchase.Find(id);
            if (customer_Purchase == null)
            {
                return HttpNotFound();
            }
            return View(customer_Purchase);
        }

        // GET: Customer_Purchase/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "Employee_No");
            return View();
        }

        // POST: Customer_Purchase/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CustomerID,EmployeeID,TotalPrice,LoyaltyPoints,Date,RecieptNo,RecieptDate")] Customer_Purchase customer_Purchase)
        {
            if (ModelState.IsValid)
            {
                db.Customer_Purchase.Add(customer_Purchase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "Employee_No", customer_Purchase.EmployeeID);
            return View(customer_Purchase);
        }

        // GET: Customer_Purchase/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Purchase customer_Purchase = db.Customer_Purchase.Find(id);
            if (customer_Purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "Employee_No", customer_Purchase.EmployeeID);
            return View(customer_Purchase);
        }

        // POST: Customer_Purchase/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CustomerID,EmployeeID,TotalPrice,LoyaltyPoints,Date,RecieptNo,RecieptDate")] Customer_Purchase customer_Purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer_Purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "Employee_No", customer_Purchase.EmployeeID);
            return View(customer_Purchase);
        }

        // GET: Customer_Purchase/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Purchase customer_Purchase = db.Customer_Purchase.Find(id);
            if (customer_Purchase == null)
            {
                return HttpNotFound();
            }
            return View(customer_Purchase);
        }

        // POST: Customer_Purchase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer_Purchase customer_Purchase = db.Customer_Purchase.Find(id);
            db.Customer_Purchase.Remove(customer_Purchase);
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
