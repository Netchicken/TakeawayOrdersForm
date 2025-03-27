using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using TakeawayOrdersForm.DTO;

namespace TakeawayOrdersForm.Pages
{
    public class IndexModel : PageModel
    {
        //https://code-maze.com/implement-checkbox-list-aspnetcore/

        [BindProperty]
        public MealOrder mealOrder { get; set; } = new MealOrder();
        [BindProperty]
        public List<string> SelectedMealOrders { get; set; } = new List<string>();

        public void OnGet()
        {

        }

        public void OnPost()
        {

            var selectedCourses = mealOrder.MealList.Where(x => x.IsChecked).ToList();

            float total = 0;

            for (int i = 0; i < selectedCourses.Count; i++)
            {
                total += selectedCourses[i].Price * selectedCourses[i].CountOfMeals;
            }


            var selectedMembership = mealOrder.selectedMembership;

        }
    }
}
