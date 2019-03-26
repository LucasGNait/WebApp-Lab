using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTedModels
{
    [Table("Assignments", Schema = "dbo")]
    public class Assignment
    {
        [Key]
        public int AssignmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OfferingID { get; set; }
        public short PossibleMarks { get; set; }
        public short? ExtraBonusMarks { get; set; }
        public short Weight { get; set; }

    }
}
