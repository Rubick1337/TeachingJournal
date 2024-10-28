using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class PlannedTask
    {
        [Key]
        public int PtId { get; set; }

        public DateTime PtStartDate { get; set; }

        public DateTime PtEndDate { get; set; }

        public int PtGrId { get; set; }

        public int PtSubgrId { get; set; }

        public int PtStId { get; set; }

        public string PtDiscription { get; set; }

        public int PtSubjectId { get; set; }
    }
}
