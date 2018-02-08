using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/form")]
        public ActionResult Form(){
            return View();
        }
        [HttpGet("/index")]
        public ActionResult Index(){
            return View();
        }
        [HttpGet("/mymusic")]
        public ActionResult DisplayAll(){
            List<CD> allCDS = CD.GetAll();
            return View(allCDS);
        }
        [HttpPost("/mymusic")]
        public ActionResult MyMusic(){
            //Request.Form for HttpPost Requests
            //Request.Query for HttpGet Requests
            //Use Request. when wanting to get variable information from forms.
            string titleIn = Request.Form["title"];
            string genreIn = Request.Form["genre"];
            string artistIn = Request.Form["artist"];
            CD fun = new CD(titleIn, genreIn, artistIn);
            fun.PushToList();
            List<CD> allCDS = CD.GetAll();
            return View(allCDS);
        }
    }
}
