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
    public class GoalKeepersController : Controller
    {
        private GoalKeeperDBContext db = new GoalKeeperDBContext();

        // GET: GoalKeepers
        public ActionResult Index()
        {
            return View(db.GoalKeepers.ToList());
        }

        // GET: GoalKeepers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoalKeeper goalKeeper = db.GoalKeepers.Find(id);
            if (goalKeeper == null)
            {
                return HttpNotFound();
            }
            return View(goalKeeper);
        }

        // GET: GoalKeepers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoalKeepers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,TeamPlayerContractedTo,DateStamp,Position,AerialAbility,CommanOfArea,Communication,Eccentricity,FirstTouch,FreeKickTaking,Handling,Kicking,OneOnOne,PeanaltyTacking,Reflexes,RushingOut,TendencyToPunch,Throwing,Aggression,Anticipation,Bravery,Composure,Concentration,Decisions,Determination,Flair,Leadership,OffTheBall,Positioning,Teamwork,Vision,WorkRate,Acceleration,Agility,Balance,JumpingReach,NaturalFitnesss,Pace,Stamina,Strength,Technique,OutfieldRating")] GoalKeeper goalKeeper)
        {
            if (ModelState.IsValid)
            {
                db.GoalKeepers.Add(goalKeeper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goalKeeper);
        }

        // GET: GoalKeepers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoalKeeper goalKeeper = db.GoalKeepers.Find(id);
            if (goalKeeper == null)
            {
                return HttpNotFound();
            }
            return View(goalKeeper);
        }

        // POST: GoalKeepers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,TeamPlayerContractedTo,DateStamp,Position,AerialAbility,CommanOfArea,Communication,Eccentricity,FirstTouch,FreeKickTaking,Handling,Kicking,OneOnOne,PeanaltyTacking,Reflexes,RushingOut,TendencyToPunch,Throwing,Aggression,Anticipation,Bravery,Composure,Concentration,Decisions,Determination,Flair,Leadership,OffTheBall,Positioning,Teamwork,Vision,WorkRate,Acceleration,Agility,Balance,JumpingReach,NaturalFitnesss,Pace,Stamina,Strength,Technique,OutfieldRating")] GoalKeeper goalKeeper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goalKeeper).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goalKeeper);
        }

        // GET: GoalKeepers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoalKeeper goalKeeper = db.GoalKeepers.Find(id);
            if (goalKeeper == null)
            {
                return HttpNotFound();
            }
            return View(goalKeeper);
        }

        // POST: GoalKeepers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoalKeeper goalKeeper = db.GoalKeepers.Find(id);
            db.GoalKeepers.Remove(goalKeeper);
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
