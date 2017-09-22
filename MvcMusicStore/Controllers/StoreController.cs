using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        private MusicStoreDB db = new MusicStoreDB();

        // GET: /Store/
        public string Index()
        {
            return "Hello from store.Index";
        }

        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        // GET: /Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        } 

        // GET: /Store/Edit/5
        public string Edit(string album)
        {
            string message = "Store.Details, Album Title";
            return message;
        }



        protected override void Dispose(bool disposing)
        {
            
            base.Dispose(disposing);
        }
    }
}