using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

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
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }

    }

    public class CourseVM
    {
        public string Number { get; set; }

        public string Name { get; set; }

        public string Instructor { get; set; }

    }
}
