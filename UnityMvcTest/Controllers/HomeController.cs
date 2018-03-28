using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityMvcTest.Code;

namespace UnityMvcTest.Controllers
{
    public class HomeController : Controller
    {
        private IMessageService _messageService = null;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
        }
    }
}