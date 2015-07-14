using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using TestTask3.Data;

namespace TestTask3
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Запуск менеджера миграций
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            IMigrationManager migrationManager = new MigrationManager(connectionString);
            migrationManager.Start();

        }
    }
}