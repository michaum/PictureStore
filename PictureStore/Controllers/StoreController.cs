using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PictureStore.Models;

namespace PictureStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        PictureStoreEntities storeDB = new PictureStoreEntities();
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            
            return View(genres);
        }

        // GET: Browse Store
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre {Name = genre};
            return View(genreModel);
        }

        // GET: Store Details
        public ActionResult Details(int id)
        {
            var album = new Album {Title = "Album " + id};
            return View(album);
        }
    }
}