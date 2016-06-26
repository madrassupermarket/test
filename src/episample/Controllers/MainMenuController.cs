using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using episamplebase.ContentTypes;
using EPiServer.ServiceLocation;

namespace episample.Controllers
{
    public class MainMenuController : Controller
    {
       

        private Injected<IContentLoader> ContentLoader { get; set; }
        //MainMenuController(IContentLoader contentLoader)
        //{
        //    _contentLoader = contentLoader;
        //}
        // GET: MainMenu
        public ActionResult GlobalMenu()
        {

            var startPageref = ContentReference.StartPage;
           
            var pages = new List<PageData>();


            var startPage = ContentLoader.Service.Get<PageData>(startPageref);
           
            pages.Add(startPage);

            pages.AddRange(ContentLoader.Service.GetChildren<PageData>(startPageref));

            var teststring = $"Hello {startPage.Name}";
            ;

            //  pages.AddRange(ContentLoader.Service.GetChildren<PageData>(startPageref));




            return View(pages);
        }
    }
}