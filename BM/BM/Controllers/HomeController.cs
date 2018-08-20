using BM.DF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BatchService batchservice = new BatchService();
        public ActionResult Index()
        {
            
            return View(batchservice.GetBatches());
        }
        public ActionResult Post()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Post(Batch batch)
        {
            batchservice.AddItem(batch);
            return View() ;
        }
    }
}