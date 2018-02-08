using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Form(){
            return View();
        }
        [HttpGet("/mymusic/delete")]
        public ActionResult DeleteAll()
        {
            CD.ClearAll();
            List<CD> allCds = CD.GetAll();
            return View("mymusic", allCds);
        }
        [HttpGet("/mymusic")]
        public ActionResult MyMusicGet(){
            List<CD> allCds = CD.GetAll();
            return View("mymusic",allCds);
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
        [HttpGet("/mymusic/{id}")]
        public ActionResult SongDetail(int id){
            return View(CD.Find(id));
        }
    }
}
