using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VRSystem.Data;
using VRSystem.Models;

namespace VRSystem.Controllers
{
    [Authorize]
    public class VideoController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostEnvironment;

        public VideoController(ApplicationDbContext db, IHostingEnvironment hostEnvironment)
        {
            _db = db;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Videos> objList = _db.Videos;
           
             
            foreach(var i in objList)
            {
                var k = _db.Subscriptions.Where(a => a.Vid == i.ID && a.UserName == User.Identity.Name);
                if(k.Count() >= 1)
                {
                    objList = objList.Where(u => u.ID != i.ID).ToList();
                }
                

            }

            

            return View(objList);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAsync(Videos obj, IFormFile ImageFile, IFormFile VideoFile) 
        {
            var fileName = Path.GetFileName(ImageFile.FileName);
            var ext = Path.GetExtension(ImageFile.FileName);
            string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
            string myfile = name + ext; //appending the name with id  
            // store the file inside ~/project folder(Img)  
            var path = Path.Combine("img/", myfile);
            obj.ImagePath = path;
            path = Path.Combine(_hostEnvironment.WebRootPath+"/img", myfile);
            using (Stream fileStream = new FileStream(path, FileMode.Create)) {
                await ImageFile.CopyToAsync(fileStream);
            }


            var fileName1 = Path.GetFileName(VideoFile.FileName);
            var ext1 = Path.GetExtension(VideoFile.FileName);
            string name1 = Path.GetFileNameWithoutExtension(fileName1); //getting file name without extension  
            string myfile1 = name1 + ext1; //appending the name with id  
            // store the file inside ~/project folder(Img)  
            var path1 = Path.Combine("videos/", myfile1);
            obj.VideoPath = path1;
            path = Path.Combine(_hostEnvironment.WebRootPath + "/videos", myfile1);
            using (Stream fileStream = new FileStream(path, FileMode.Create))
            {
                await VideoFile.CopyToAsync(fileStream);
            }




            _db.Videos.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
