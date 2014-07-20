using Angular4DotNetMvc.Models.CourseVm;
using Angular4DotNetMvc.Models.Instructors;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMvc.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm
            {
                Courses = this.GetSerializedCourses(),
                Instructors = this.GetSerializedInstructors()
            };

            return registrationVm;
        }

        public string GetSerializedCourses()
        {
            var courses = new[]
                {                        
                    new CourseVM {Number = "CREA101", Name = "Triangle Offense for Dummies", Instructor = "Kobe Bryant"},
                    new CourseVM {Number = "DARK502", Name = "Sharp shooting on the court", Instructor = "Kevin Durant"},
                    new CourseVM {Number = "TRAN201", Name = "Passing, chase down blocks, and more", Instructor = "Lebron James"}
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializedCourses;
        }

        public string GetSerializedInstructors()
        {
            var instructors = new[]
                {                        
                    new InstructorVm { Name = "Kobe Bryant", Email = "kobe.bryant@lakers.com", RoomNumber = 1001 },
                    new InstructorVm { Name = "Kevin Durant", Email = "kdurant@okcthunder.com", RoomNumber = 105 },
                    new InstructorVm { Name = "Lebron James", Email = "lebronjames@lrmr.com", RoomNumber = 102 }
                };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serializedInstructors;
        }
    }
}