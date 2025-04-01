using TakeawayOrdersForm.Model;

namespace TakeawayOrdersForm.Operations
{

    public class CalculateCost
    {

        // This method calculates the total cost of the selected meals, including membership discounts and tax.
        public float CalculateMealCost(List<CheckBoxMeals> selectedCourses, Membership selectedMembership)
        {
            float total = 0;

            // Calculate the total cost of the selected meals.
            for (int i = 0; i < selectedCourses.Count; i++)
            {
                total += selectedCourses[i].Price * selectedCourses[i].CountOfMeals;
            }

            // Apply the membership discount to the total cost.
            float grandTotal = (total * selectedMembership.Discount) / 100 + total;

            // Apply additional discounts based on the number of selected meals.
            grandTotal = ApplyMembershipDiscount(selectedCourses, grandTotal);

            // Add tax to the grand total.
            grandTotal = (float)((grandTotal * Discounts.Tax) + grandTotal);

            return grandTotal;
        }

        // This private method applies additional discounts based on the number of selected meals.
        private float ApplyMembershipDiscount(List<CheckBoxMeals> selectedCourses, float grandTotal)
        {
            // Apply a discount based on the number of selected meals.
            switch (selectedCourses.Count)
            {
                case 2:
                    // Apply a discount for selecting two meals.
                    grandTotal = grandTotal - (float)((grandTotal * Discounts.TwoMealDiscount));
                    break;
                case 3:
                    // Apply a discount for selecting three meals.
                    grandTotal = grandTotal - (float)((grandTotal * Discounts.ThreeMealDiscount));
                    break;
                default:
                    // No additional discount for other cases.
                    break;
            }

            return grandTotal;
        }
    }


}



