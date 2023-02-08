using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;       
        public Category category { get; set; }
        //public string tname { get; set; }
        //public string Displayorder { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if(category.Name == category.DisplayOrder.ToString())
            {
                //if we add model error than modestateError is invalid by default
                //and this will display in summary panel of cshtml file 
                ModelState.AddModelError(string.Empty,"Name and Display order cannot be same ");
                
                //this will display the error below the  name feild 
                //ModelState.AddModelError("Category.Name", "Name and Display order cannot be same");
            }
            if(ModelState.IsValid)// used to validate the data inside it 
            {
                await _db.Category.AddAsync(category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            //string t = $"{tname} order is {Displayorder}";
            //ModelState.IsValid
            
            return Page();
        }
    }
}
