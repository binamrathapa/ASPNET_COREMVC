using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title")] Album album)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/" + album.Title);
                    ViewData["Message"] = "Album is successfully created";
                }
                catch(Exception ex)
                {
                    ViewData["Message"] = ex.Message;
                }
                    //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(album);
        }
    }
}
