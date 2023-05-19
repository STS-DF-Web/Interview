using System.Web.Mvc;

namespace InterviewProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //1. Create new method in controller and change route to default to the new method.  Name it CustomIndex() and create the view for it.
            //2. Create new project and call it InterviewProject.Library and use as your Business Logic Container
            //3. Create new project and call it InterviewProject.Data and use as your Data Access Container
            //4. Get the Entity Framework package from Microsoft.
            //5. Use EF to get database data and propagate it up to the view. - display collection on view.  
            //The db instance name is di-sql201601 and the database name is InterviewTest.  Username=InterviewTest_User, Pwd=Cl)u*^St+Rrf!u@ch
            //6. Now get Ioc of choice and use the Ioc/DI container. - If you have used Ioc before
            //7. Unit test one of the methods you created.

            return View();
        }
    }
}