using Camplify.Data;
using Camplify.Data.Models;
using Camplify.Data.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camplify.Controllers
{
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public JobController(ApplicationDbContext context)
        {
            this.db = context;
        }
        [HttpPost]
        [Route("incident_list")]
        public IActionResult GetIncidents()
        {
            var result = db.Checklist.Include("Photo").ToList();
            return Ok(result);
        }
        [HttpPost]
        [Route("apply_job")]
        public IActionResult GetIncidents(Job _job)
        {
            _job.Status = "Requested";
            _job.Date = DateTime.Now;
            db.Job.Add(_job);
            db.SaveChanges();
            return Ok(new Response { Status = "Success", Message = "Job Added Successfully!" });
        }
        //[HttpPost]
        //[Route("apply_job")]
        //public IActionResult GetIncidentsByCustomerID(string customerId)
        //{
        //    var result = (from i in db.Job
        //                  join j in db.Checklist
        //                  on i.ChecklistId equals j.ChecklistId
        //                  where j.UserId == customerId
        //                  )

        //    db.Job.Add(_job);
        //    db.SaveChanges();
        //    return Ok(new Response { Status = "Success", Message = "Job Added Successfully!" });
        //}
    }
}
