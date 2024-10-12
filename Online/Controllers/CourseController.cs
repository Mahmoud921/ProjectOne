using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Online.Data;
using Online.Models;
using IHostingEnvironment= Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Online.Controllers
{
    public class CourseController : Controller
    {
        ApplicationDbContext _context;
        public CourseController(ApplicationDbContext context,IHostingEnvironment hosting)
        {
            _context = context;
            _host = hosting;

        }
        private readonly IHostingEnvironment _host;
        public IActionResult Index()
        {
            List<Course> cr = _context.Courses.ToList();
            ViewData["categ"] = _context.Categoryes.ToList();
            
            return View(cr);
        }
        public IActionResult New()
        {
            ViewData["categ"] = _context.Categoryes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Save(Course course)
        {

            if (course.Title !=null)
            {
                string fileName = string.Empty;
                if (course.clientFile != null)
                {
                    string myUploud = Path.Combine(_host.WebRootPath, "images");
                    fileName = course.clientFile.FileName;

                    string fullPath = Path.Combine(myUploud, fileName);
                    course.clientFile.CopyTo(new FileStream(fullPath,FileMode.Create));
                    course.Image = fileName;
                }
                    _context.Courses.Add(course);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                
            }
            return View("New", course);
        }
    }
}
