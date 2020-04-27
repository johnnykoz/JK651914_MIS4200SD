using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JK651914_MIS4200SD.Models;
using JK651914_MIS4200SD.Models.DAL;

namespace JK651914_MIS4200SD.Controllers
{
    public class OrderDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: OrderDetails
        public ActionResult Index()
        {
            var order = db.Order.Include(o => o.Cars).Include(o => o.Owners);
            return View(order.ToList());
        }

        // GET: OrderDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderDetails = db.Order.Find(id);
            if (orderDetails == null)
            {
                return HttpNotFound();
            }
            return View(orderDetails);
        }

        // GET: OrderDetails/Create
        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.Cars, "carId", "brand");
            ViewBag.ownerId = new SelectList(db.Owners, "ownerID", "fistName");
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "orderdetailsId,price,CarId,ownerId")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                db.Order.Add(orderDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.Cars, "carId", "brand", orderDetails.CarId);
            ViewBag.ownerId = new SelectList(db.Owners, "ownerID", "fistName", orderDetails.ownerId);
            return View(orderDetails);
        }

        // GET: OrderDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderDetails = db.Order.Find(id);
            if (orderDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.Cars, "carId", "brand", orderDetails.CarId);
            ViewBag.ownerId = new SelectList(db.Owners, "ownerID", "fistName", orderDetails.ownerId);
            return View(orderDetails);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "orderdetailsId,price,CarId,ownerId")] OrderDetails orderDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.Cars, "carId", "brand", orderDetails.CarId);
            ViewBag.ownerId = new SelectList(db.Owners, "ownerID", "fistName", orderDetails.ownerId);
            return View(orderDetails);
        }

        // GET: OrderDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderDetails = db.Order.Find(id);
            if (orderDetails == null)
            {
                return HttpNotFound();
            }
            return View(orderDetails);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderDetails orderDetails = db.Order.Find(id);
            db.Order.Remove(orderDetails);
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
