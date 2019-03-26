using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTedModels
{
    [Table("Courses", Schema = "dbo")]
    public class Course
    {
        [Key]
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public decimal Credits { get; set; }
        public int TotaltHours { get; set; }
        public int ClassroomType { get; set; }
        public int Term { get; set; }
        public decimal Tuition { get; set; }
        public string Description { get; set; }
    }
}
