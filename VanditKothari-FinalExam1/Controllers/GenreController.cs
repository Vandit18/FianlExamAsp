using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanditKothari_FinalExam1.Models;


// Vandit Kothari
// 200299657
// creates controller for Genre
namespace VanditKothari_FinalExam1.Controllers
{
    public class GenreController : Controller
    {

        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Genre
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }
    }
}