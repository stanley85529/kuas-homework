using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class 名稱Controller : Controller
    {
        // GET: 名稱

        public ActionResult Index(int? 名稱ID)
        {
            List<Models.Albums> result = new List<Models.Albums>();
            Service.Database2Service db2 = new Service.Database2Service();

            var 名稱s=db2.LoadAll名稱();

            ViewBag.名稱s = 名稱s;
            ViewBag.Selected名稱ID = 名稱ID;

            if (名稱ID != null)
            {
                result = db2.LoadAlbumBy名稱ID(名稱ID.Value);
            }
            return  View(result);
        }

    }
}