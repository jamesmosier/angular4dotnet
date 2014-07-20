using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    using Newtonsoft.Json;

    public class CoursesController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", this.GetSerializedCourseVms());
        }

        public string GetSerializedCourseVms()
        {
            var courses = new[]
                {                        
                    new CourseVM {Number= "CREA101", Name= "Care of magical stuff", Instructor="Rob Zombie"},
                    new CourseVM {Number= "DARK502", Name= "Defense Against Dark Matter", Instructor="Marilyn Manson"},
                    new CourseVM {Number= "TRAN201", Name= "Tranfiguration", Instructor="Minerva McGonagall"}
                };
            return JsonConvert.SerializeObject(courses);
        }

    }

    public class CourseVM
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public string Instructor { get; set; }

    }
}
