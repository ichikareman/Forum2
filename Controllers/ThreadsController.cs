using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForumServices.Implmentations;
using AutoMapper;
using Forum2.ViewModel;

namespace Forum2.Controllers
{
    public class ThreadsController : Controller
    {
        //
        // GET: /Threads/
        private ForumService _service;
        public ThreadsController()
        {
            _service = new ForumService();
        }

        public ActionResult Index()
        {
            var a = Mapper.Map<IEnumerable<ThreadViewModels>>(_service.GetAll());
            return View(a);
            //return View(Mapper.Map<ThreadViewModels>(_service.GetThread(1)));
        }

    }
}
