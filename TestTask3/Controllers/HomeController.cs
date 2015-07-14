using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace TestTask3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportSnapshot()
        {
            StiReport report = new StiReport();

            report.Load(Server.MapPath("~/Content/WorkTimeLog3.mrt"));

            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult Interaction()
        {
            return StiMvcViewer.InteractionResult();
        }

    }
}