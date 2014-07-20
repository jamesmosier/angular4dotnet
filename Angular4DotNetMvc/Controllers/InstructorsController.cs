using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class InstructorsController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
        }

       

    }


}
