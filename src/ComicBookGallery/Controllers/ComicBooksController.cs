﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
            /*if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            
            return new ContentResult()
            {
                Content = "Hello from the cb controller"
            };*/

            //return Content("Hello from the cb controller");

            return View();
        }
    }

}

