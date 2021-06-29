using System;
using System.Collections.Generic;
using System.Text;

namespace Camplify.Data.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int ChecklistId { get; set; }
        public string Photos { get; set; }
    }
}
