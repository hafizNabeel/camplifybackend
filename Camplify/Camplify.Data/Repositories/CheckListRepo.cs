using Camplify.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camplify.Data.Repositories
{
    public class CheckListRepo
    {
       private readonly ApplicationDbContext db = new ApplicationDbContext();

        public bool Insert(Checklist obj)
        {
           
            db.Checklist.Add(obj);
            db.SaveChanges();

            foreach (var item in obj.Categories)
            {
                item.ChecklistId = obj.ChecklistId;
                db.Add(item);
                db.SaveChanges();
            }
            foreach (var pic in obj.Photo)
            {
                pic.ChecklistId = obj.ChecklistId;
                db.Add(pic);
                db.SaveChanges();
            }
            return true;
        }
    }
}
