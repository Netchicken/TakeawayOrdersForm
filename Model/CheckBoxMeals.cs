﻿namespace TakeawayOrdersForm.Model
{
    public class CheckBoxMeals
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
        public float Price { get; set; }
        public float CountOfMeals { get; set; }
        public bool IsChecked { get; set; }
        public string Image { get; set; }
    }
}
