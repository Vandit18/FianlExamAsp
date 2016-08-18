using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanditKothari_FinalExam1.Models;


// Vandit Kothari
// 200299657
// creates controller for Album
namespace VanditKothari_FinalExam1.Controllers
{
    public class AlbumController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Genre
        public ActionResult Index()
        //ghkhkh
        {
            List<Album> genres = storeDB.Albums.ToList();

            return View(genres);
        }
    }
}