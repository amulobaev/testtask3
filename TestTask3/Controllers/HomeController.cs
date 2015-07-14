using System.Configuration;
using System.Web.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
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
            
            // Загрузка шаблона отчета из файла
            report.Load(Server.MapPath("~/Content/WorkTimeLog3.mrt"));
            
            // Настройка подключения к базе для отчета
            StiSqlDatabase sqldb = report.Dictionary.Databases["SqlConnection"] as StiSqlDatabase;
            if (sqldb != null)
            {
                sqldb.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
            
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