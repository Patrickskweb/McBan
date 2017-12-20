using McBan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McBan.Controllers {
    public class AdminController : Controller {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index() {
            return View();
        }

        public ActionResult Bans() {

            var getBans = db.McUsers.ToList().Where(x => x.Expired == false).OrderByDescending(y => y.BannedOn).ToList(); //Gets all active bans and sorts them into a list.

            return View(getBans);
        }
    }
}