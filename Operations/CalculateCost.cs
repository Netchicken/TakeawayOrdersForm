using TakeawayOrdersForm.DTO;

namespace TakeawayOrdersForm.Operations
{

    public class CalculateCost
    {
        //  public MealOrder mealOrder { get; set; } = new MealOrder();


        public float CalculateMealCost(List<CheckBoxMeals> selectedCourses, Membership selectedMembership)
        {
            float total = 0;

            for (int i = 0; i < selectedCourses.Count; i++)
            {
                total += selectedCourses[i].Price * selectedCourses[i].CountOfMeals;
            }




            // Membership discount

            float grandTotal = (total * selectedMembership.Discount) + total;

            grandTotal = ApplyMembershipDiscount(selectedCourses, grandTotal);

            // Tax added on
            grandTotal = (float)((grandTotal * Discounts.Tax) + grandTotal);
            return grandTotal;
        }





        private float ApplyMembershipDiscount(List<CheckBoxMeals> selectedCourses, float grandTotal)
        {
            // Discount for multiple brands
            switch (selectedCourses.Count)
            {
                case 2:
                    grandTotal = grandTotal - (float)((grandTotal * Discounts.TwoMealDiscount));
                    break;
                case 3:
                    grandTotal = grandTotal - (float)((grandTotal * Discounts.ThreeMealDiscount));
                    break;
                default:
                    break;
            }

            return grandTotal;
        }
    }



};





//   private void btnCalculate_Click(object sender, EventArgs e)
//    {
//        

//        


//       

//       

//       
//        grandTotal = twoPersonMealTotal + fourPersonMealTotal + sixPersonMealTotal;

//        if (rbBronze.Checked)
//        {
//            grandTotal = (grandTotal * bronze) + grandTotal;
//        }
//        else if (rbxSilver.Checked)
//        {
//            grandTotal = (grandTotal * silver) + grandTotal;
//        }

//        //discount for multiple brands
//        switch (countOfMeals)
//        {
//            case 2:
//                lblDiscountAmount.Text = "$" + (grandTotal * 0.03).ToString();
//                grandTotal = grandTotal - (float)((grandTotal * 0.03));
//                break;
//            case 3:
//                lblDiscountAmount.Text = "$" + (grandTotal * 0.05).ToString();
//                grandTotal = grandTotal - (float)((grandTotal * 0.05));
//                break;
//            default:
//                // code block
//                break;
//        }

//        //tax added on
//        lblTaxAmount.Text = "$" + (grandTotal * 0.08).ToString();
//        grandTotal = (float)((grandTotal * 0.08) + grandTotal);

//        lblTotalPrice.Text = "$" + grandTotal.ToString();


//    }





//}
