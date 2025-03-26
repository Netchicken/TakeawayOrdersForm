namespace TakeawayOrdersForm.DTO
{
    public class MealOrder
    {
        public string[] meals = ["Two Person Meal", "Four Person Meal", "Six Person Meal"];
        public string[] membershipTypes = ["Bronze", "Silver", "Gold"];
        public int[] mealPrices = [15, 20, 30];

        public int CountOfMeals { get; set; }
        public int CountOfTotalMeals { get; set; }
        public int TwoPersonMealTotal { get; set; }
        public int FourPersonMealTotal { get; set; }
        public int SixPersonMealTotal { get; set; }
        public int GrandTotal { get; set; }
        public float Bronze { get; set; }
        public float Silver { get; set; }
        public float SilverTotal { get; set; }
        public float BronzeTotal { get; set; }
        public float GoldTotal { get; set; }
        public float Gold { get; set; }
        public float SilverDiscount { get; set; }
        public float BronzeDiscount { get; set; }
        public float GoldDiscount { get; set; }

        public float GrandTotalDiscount { get; set; }
        public float GrandTotalAfterDiscount { get; set; }




    }
}
