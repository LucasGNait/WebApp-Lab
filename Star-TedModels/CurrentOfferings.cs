using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTedModels
{
    [Table("CurrentOfferings", Schema = "dbo")]
    public class CurrentOffering
    {
        [Key]
        public int OfferingID { get; set; }
        public string ProgramName { get; set; }
        public string Semester { get; set; }
        public string CourseID { get; set; }
    }
}
