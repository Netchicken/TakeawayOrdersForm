using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Diagnostics;

using TakeawayOrdersForm.DTO;
using TakeawayOrdersForm.Operations;

namespace TakeawayOrdersForm.Pages
{
    public class IndexModel : PageModel
    {
        //https://code-maze.com/implement-checkbox-list-aspnetcore/

        [BindProperty]
        public MealOrder mealOrder { get; set; } = new MealOrder();
        [BindProperty]
        public List<string> SelectedMealOrders { get; set; } = new List<string>();

        public CalculateCost calculateCost { get; set; } = new CalculateCost();

        public void OnGet()
        {

        }

        public void OnPost()
        {

            List<CheckBoxMeals>? selectedCourses = mealOrder.MealList.Where(x => x.IsChecked).ToList();

            Debug.WriteLine("Selected Courses: " + selectedCourses);


            //var selectedMembership = mealOrder.MembershipList.Where(x => x.selectedMembership == x.LabelName).ToList(); 

            // Debugging information
            Debug.WriteLine("Selected Membership BSG: " + mealOrder.selectedMembershipBSG);

            Membership? selectedMembership = new Membership();
            foreach (var item in mealOrder.MembershipList)
            {
                if (mealOrder.selectedMembershipBSG == item.LabelName)
                {
                    selectedMembership = item;
                    // Debugging information
                    Debug.WriteLine("Selected Membership: " + selectedMembership.Discount);
                }
            }


            ViewData["totalCost"] = Math.Round(calculateCost.CalculateMealCost(selectedCourses, selectedMembership), 2);





        }
    }
}
