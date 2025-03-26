using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using TakeawayOrdersForm.DTO;

namespace TakeawayOrdersForm.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public MealOrder mealOrder { get; set; } = new MealOrder();

        public void OnGet()
        {

        }
    }
}
