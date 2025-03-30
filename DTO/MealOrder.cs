namespace TakeawayOrdersForm.DTO
{
    public class MealOrder
    {
        public string[] meals = ["Two Person Meal", "Four Person Meal", "Six Person Meal"];

        public List<CheckBoxMeals> MealList { get; set; } = new List<CheckBoxMeals>() {
            new CheckBoxMeals
            {Id=1, LabelName="Two Person Meal", Price = 15,IsChecked=false, Image="2.png"},
            new CheckBoxMeals
            {Id=2, LabelName="Four Person Meal", Price = 20, IsChecked=false, Image="4.png"},
            new CheckBoxMeals
            {Id=3, LabelName="Six Person Meal", Price = 30, IsChecked=false, Image="6.png"},
                    };

        public List<Membership> MembershipList { get; set; } = new List<Membership>() {
            new Membership
            {Id=1,LabelName="Bronze", NameTotal = 0, Discount = 10},
            new Membership
            {Id=2, LabelName="Silver", NameTotal = 0, Discount = 5},
            new Membership
            {Id=3,LabelName="Gold", NameTotal = 0, Discount = 0},
                    };

        public string selectedMembershipBSG { get; set; }




    }
}
