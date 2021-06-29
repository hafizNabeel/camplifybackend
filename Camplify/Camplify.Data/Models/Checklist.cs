using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Camplify.Data.Models
{
    public class Checklist
    {
        public int ChecklistId { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public bool IsDemage { get; set; }
        public string DemageDesc { get; set; }
        public DateTime DemageOccurDate { get; set; }
        public ICollection<Photo> Photo { get; set; }
        public ICollection<DemageCategory> Categories { get; set; }
    }
}
