using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanditKothari_FinalExam1.Models;


// Jose Mathew
// modifid 18/08/2016
// 200298627
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