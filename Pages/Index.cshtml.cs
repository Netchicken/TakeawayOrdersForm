using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Diagnostics;

using TakeawayOrdersForm.Model;
using TakeawayOrdersForm.Operations;

namespace TakeawayOrdersForm.Pages
{
    // The IndexModel class represents the data and actions for the Index page.
    public class IndexModel : PageModel
    {
        //https://code-maze.com/implement-checkbox-list-aspnetcore/

        // BindProperty attribute binds the form data to the MealOrder property.
        [BindProperty]
        public MealOrder mealOrder { get; set; } = new MealOrder();

        // BindProperty attribute binds the form data to the SelectedMealOrders property.
        [BindProperty]
        public List<string> SelectedMealOrders { get; set; } = new List<string>();

        // An instance of the CalculateCost class to calculate the total cost.
        public CalculateCost calculateCost { get; set; } = new CalculateCost();

        // OnGet method is called when the page is first loaded.
        public void OnGet()
        {

        }

        // OnPost method is called when the form is submitted.
        public void OnPost()
        {
            // Get the list of selected meals (those that are checked).
            List<CheckBoxMeals>? selectedCourses = mealOrder.MealList.Where(x => x.IsChecked).ToList();

            // Debugging information to check the selected courses.
            Debug.WriteLine("Selected Courses: " + selectedCourses);


            //var selectedMembership = mealOrder.MembershipList.Where(x => x.selectedMembership == x.LabelName).ToList(); 

            // Debugging information to check the selected membership.
            Debug.WriteLine("Selected Membership BSG: " + mealOrder.selectedMembershipBSG);

            // Find the selected membership based on the selectedMembershipBSG value.
            Membership? selectedMembership = new Membership();
            foreach (var item in mealOrder.MembershipList)
            {
                if (mealOrder.selectedMembershipBSG == item.LabelName)
                {
                    selectedMembership = item;
                    // Debugging information to check the selected membership discount.
                    Debug.WriteLine("Selected Membership: " + selectedMembership.Discount);
                }
            }

            // Calculate the total cost of the selected meals and membership discount.
            ViewData["totalCost"] = Math.Round(calculateCost.CalculateMealCost(selectedCourses, selectedMembership), 2);





        }
    }
}
