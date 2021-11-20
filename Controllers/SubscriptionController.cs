using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VRSystem.Data;
using VRSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace VRSystem.Controllers
{
    [Authorize]
    public class SubscriptionController : Controller
    {
        private readonly ApplicationDbContext _db;

       
        public SubscriptionController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        
        public IActionResult Index(int id)
        {
            Videos video = _db.Videos.Find(id);
            ViewData["video"] = video;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Subscriptions sub)
        {
            sub.ValidateTill = DateTime.Now;
            sub.Id = 0;
        
            sub.UserName = User.Identity.Name;
            sub.IsActive = true;
            _db.Subscriptions.Add(sub);
            _db.SaveChanges();
            return Redirect("/video");
        }
    }
}
