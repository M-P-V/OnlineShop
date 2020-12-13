using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services;
using System.Threading.Tasks;

namespace OnlineShop.Web.ViewComponents
{
    [ViewComponent(Name = "Categories")]
    public class CategoriesViewComponent: ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetCategoriesListAsync();

            return View(categories);
        }
    }
}
