using fri_pm_music_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fri_pm_music_store.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var albums = new List<Album>();

            //make a  mock list of 10 albums
            for (int i = 1; i <= 10; i++)
           {
                albums.Add(new Album { Title = "Album" + 1.ToString() });
           }

            //pass mock data to view 

            ViewBag.albums = albums;
            
            return View();
        }
    }
}