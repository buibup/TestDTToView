using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDTToView.SQL;

namespace TestDTToView.Controllers
{
    public class HomeController : Controller
    {
        private SQLDb sqlDb = new SQLDb();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.Message = "Test Page.";

            DataTable dt = new DataTable();
            string cmd = "Select top 10 [EMP_ID],[TTL],[NME],[OFF_CD_DES],[PAY_GRP],[GRP],[POS_DES],[POS],[DEP],[DEP_DES] From ethicnur";
            dt = sqlDb.GetDTByQuery(cmd);

            return View(dt);
        }
    }
}