using BulkyRazor.Data;
using BulkyRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
