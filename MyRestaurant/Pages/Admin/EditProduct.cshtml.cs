using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRestaurant.Data;
using MyRestaurant.Models;
using System.IO;
using System.Threading.Tasks;

namespace MyRestaurant.Pages.Admin
{
    public class EditProductModel : PageModel
    {
        private readonly MyRestaurantContext _context;
        private readonly IHostingEnvironment _ihostingEnvironment;

        public EditProductModel(MyRestaurantContext context, IHostingEnvironment ihostingEnvironment)
        {
            _context = context;
            _ihostingEnvironment = ihostingEnvironment;
        }

        [BindProperty]
        public Product Product { get; set; }
        public string FileName { get; set; }

        public IActionResult OnGet(int id)
        {
            Product = _context.Products.Find(id);

            if (Product == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(IFormFile photo)
        {
            var path = Path.Combine(_ihostingEnvironment.WebRootPath, "img", photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            await photo.CopyToAsync(stream);

            if (ModelState.IsValid)
            {
                var ProdFromDb = await _context.Products.FindAsync(Product.ProductId);
                ProdFromDb.Category = Product.Category;
                ProdFromDb.Name = Product.Name;
                ProdFromDb.Description = Product.Description;
                ProdFromDb.Price = Product.Price;
                ProdFromDb.ImagePath = photo.FileName;

                await _context.SaveChangesAsync();
                return RedirectToPage("/Admin/AdminDash");
            }
            return RedirectToPage();
        }
    }
}
