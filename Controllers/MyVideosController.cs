using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VRSystem.Data;
using VRSystem.Models;

namespace VRSystem.Controllers
{
    [Authorize]
    public class MyVideosController : Controller
    {
        private readonly ApplicationDbContext _db;


        public MyVideosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
             List<Videos> myvideos = new List<Videos>();
            List<Videos> myvs = new List<Videos>();
            Videos video;
            // IEnumerable<Videos> myvideos;
           
            IEnumerable<Subscriptions> mysubs = (IEnumerable<Subscriptions>)_db.Subscriptions.Where(a => a.UserName == User.Identity.Name && a.IsActive == true);
            foreach(var sub in mysubs)
            {
                
                myvs = _db.Videos.Where(a => a.ID == sub.Vid).ToList();

                
                myvideos.Add(myvs[0]);

            }
           
            return View(myvideos);
        }

        public IActionResult Play(int id)
        {
            Videos video = _db.Videos.Find(id);
            ViewData["video"] = video;
            return View();
        }
    }
}
