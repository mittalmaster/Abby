using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        ApplicationDbContext _db;
        public IEnumerable<Category> Categories;
        public IndexModel(ApplicationDbContext db)
        {
            _db= db;

        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
