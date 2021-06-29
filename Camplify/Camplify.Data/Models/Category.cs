using System;
using System.Collections.Generic;
using System.Text;

namespace Camplify.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public ICollection<DemageCategory> DemageCategories { get; set; }
    }
}
