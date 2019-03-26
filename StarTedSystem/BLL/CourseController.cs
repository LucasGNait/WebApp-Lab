using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarTedModels;
using StarTedSystem.DAL;

namespace StarTedSystem.BLL
{
    public class CourseController
    {
        // Use this class to help us with CRUD maintenance of our database
        public List<Course> ListCourses()
        {
            // Make use of our "virtual database" class to get the data
            using (var context = new StarTedContext())
            {
                return context.Courses.ToList();
            }
        }
    }
}
