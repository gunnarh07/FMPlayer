using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FMLeikmenn.Models;

namespace FMLeikmenn.Controllers
{
    public class LeikmadursController : Controller
    {
        private LeikmadurDBContext db = new LeikmadurDBContext();

        // GET: Leikmadurs
        public ActionResult Index()
        {
            return View(db.Leikmenn.ToList());
        }

        // GET: Leikmadurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leikmadur leikmadur = db.Leikmenn.Find(id);
            if (leikmadur == null)
            {
                return HttpNotFound();
            }
            return View(leikmadur);
        }

        // GET: Leikmadurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leikmadurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,DateStamp,Position,Corners,Crossing,Dribbling,Finishing,FirstTouch,FreeKickTaking,Heading,LongShots,LongThrows,Marking,Passing,PenaltyTaking,Tackling,Technique,Aggression,Anticipation,Bravery,Composure,Concentration,Decisions,Determination,Flair,Leadership,OffTheBall,Positioning,Teamwork,Vision,WorkRate,Acceleration,Agility,Balance,JumpingReach,NatuaralFitnes,Pace,Stamina,Strength,GoalkeeperRating")] Leikmadur leikmadur)
        {
            if (ModelState.IsValid)
            {
                db.Leikmenn.Add(leikmadur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leikmadur);
        }

        // GET: Leikmadurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leikmadur leikmadur = db.Leikmenn.Find(id);
            if (leikmadur == null)
            {
                return HttpNotFound();
            }
            return View(leikmadur);
        }

        // POST: Leikmadurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,DateStamp,Position,Corners,Crossing,Dribbling,Finishing,FirstTouch,FreeKickTaking,Heading,LongShots,LongThrows,Marking,Passing,PenaltyTaking,Tackling,Technique,Aggression,Anticipation,Bravery,Composure,Concentration,Decisions,Determination,Flair,Leadership,OffTheBall,Positioning,Teamwork,Vision,WorkRate,Acceleration,Agility,Balance,JumpingReach,NatuaralFitnes,Pace,Stamina,Strength,GoalkeeperRating")] Leikmadur leikmadur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leikmadur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leikmadur);
        }

        // GET: Leikmadurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leikmadur leikmadur = db.Leikmenn.Find(id);
            if (leikmadur == null)
            {
                return HttpNotFound();
            }
            return View(leikmadur);
        }

        // POST: Leikmadurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Leikmadur leikmadur = db.Leikmenn.Find(id);
            db.Leikmenn.Remove(leikmadur);
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
