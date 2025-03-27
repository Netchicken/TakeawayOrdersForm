namespace TakeawayOrdersForm.DTO
{
    public class MealOrder
    {
        public string[] meals = ["Two Person Meal", "Four Person Meal", "Six Person Meal"];

        public List<CheckBoxMeals> MealList { get; set; } = new List<CheckBoxMeals>() {
            new CheckBoxMeals
            {Id=1, LabelName="Two Person Meal", Price = 15,IsChecked=false},
            new CheckBoxMeals
            {Id=2, LabelName="Four Person Meal", Price = 20, IsChecked=false},
            new CheckBoxMeals
            {Id=3, LabelName="Six Person Meal", Price = 30, IsChecked=false},
                    };

        public List<Membership> MembershipList { get; set; } = new List<Membership>() {
            new Membership
            {Id=1,LabelName="Bronze", NameTotal = 0, Discount = 10, IsChecked=false},
            new Membership
            {Id=2, LabelName="Silver", NameTotal = 0, Discount = 5, IsChecked=false},
            new Membership
            {Id=3,LabelName="Gold", NameTotal = 0, Discount = 0, IsChecked=false},
                    };



        public List<Discounts> DiscountList { get; set; } = new List<Discounts>() {
            new Discounts
            {Id=1, LabelName="10% Discount", Amount = 10},
            new Discounts
            {Id=2, LabelName="5% Discount", Amount = 5},
            new Discounts
            {Id=3, LabelName="Tax", Amount = 8},
                    };


        public string[] membershipTypes = ["Bronze", "Silver", "Gold"];
        public int[] mealPrices = [15, 20, 30];



        public float GrandTotalDiscount { get; set; }
        public float GrandTotalAfterDiscount { get; set; }

        public float Discount { get; set; }
        public float Tax { get; set; }
        public float TotalPrice { get; set; }






    }
}
