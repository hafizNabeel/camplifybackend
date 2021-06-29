using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Camplify.Data.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public int ChecklistId { get; set; }
        public string MechanicId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public int Quotation { get; set; }
        public DateTime Quotation_DATE { get; set; }

        public DateTime Date { get; set; }
    }
}
