using Camplify.Data;
using Camplify.Data.Models;
using Camplify.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Camplify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChecklistController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ChecklistController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            this.db = context;
            webHostEnvironment = hostEnvironment;
        }
        [HttpPost]
        [Route("Insert")]
        public ActionResult InsertChecklist([FromBody] Checklist obj)
         {
            try
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (obj.Photo != null)
                {
                    foreach (var item in obj.Photo)
                    {
                        string convert = item.Photos.Replace("data:image/jpeg;base64,", String.Empty);
                        byte[] bytess = Convert.FromBase64String(convert);
                        string uploadsFolder = Path.Combine(webHostEnvironment.ContentRootPath, "Uploads/Images");
                        string uniqueFileName = Guid.NewGuid().ToString() + ".jpeg";
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var imageFile = new FileStream(filePath, FileMode.Create))
                        {
                            imageFile.Write(bytess, 0, bytess.Length);
                            imageFile.Flush();
                        }
                    }
                }
                obj.UserId = userId;
                db.Checklist.Add(obj);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
       
    }
}
