namespace TakeawayOrdersForm
{
    public class formCode
    {
        //public partial class Form1 : Form
        //{
        //    public Form1()
        //    {
        //        InitializeComponent();
        //    }

        //    private void btnCalculate_Click(object sender, EventArgs e)
        //    {
        //        Single twoPersonMeal = 15, fourPersonMeal = 20, sixPersonMeal = 30;
        //        float bronze = 0.1f, silver = 0.05f;
        //        Single twoPersonMealTotal = 0, fourPersonMealTotal = 0, sixPersonMealTotal = 0, grandTotal = 0;

        //        int countOfMeals = 0;
        //        int countOfTotalMeals = 0;

        //        //check for no brand selected
        //        if (!cbxTwoPerson.Checked && !cbxSixPerson.Checked && !cbxFourPerson.Checked)
        //        {
        //            MessageBox.Show("Select at least one meal");
        //            return;
        //        }
        //        // checked for no membership selected
        //        if (!rbBronze.Checked && !rbxSilver.Checked && !rbxGold.Checked)
        //        {
        //            MessageBox.Show("Select at least one membership type");
        //            return;
        //        }


        //        if (cbxTwoPerson.Checked)
        //        {
        //            int number;

        //            if (int.TryParse(txtTwoPersonQuantity.Text, out number))
        //            {
        //                twoPersonMealTotal = number * twoPersonMeal;
        //                countOfMeals++;
        //                countOfTotalMeals += number;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Include a quantity of two person meals");
        //            }

        //        }

        //        if (cbxFourPerson.Checked)
        //        {
        //            int number;

        //            if (int.TryParse(txtfourPersonQuantity.Text, out number))
        //            {
        //                fourPersonMealTotal = number * fourPersonMeal;
        //                countOfMeals++;
        //                countOfTotalMeals += number;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Include a quantity of four person meals");
        //            }
        //        }

        //        if (cbxSixPerson.Checked)
        //        {
        //            int number;
        //            if (int.TryParse(txtSixPersonQuantity.Text, out number))
        //            {
        //                sixPersonMealTotal = number * sixPersonMeal;
        //                countOfMeals++;
        //                countOfTotalMeals += number;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Include a quantity of six person meals ");
        //            }

        //        }
        //        if (countOfTotalMeals >= 10)
        //        {

        //            MessageBox.Show("Please reduce the quantity of meals to 10 or less ");
        //            return;
        //        }

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

        //    private void btnExit_Click(object sender, EventArgs e)
        //    {
        //        this.Close();
        //    }

        //    private void btnPlaceOrder_Click(object sender, EventArgs e)
        //    {
        //        //reset button to clear all fields

        //        lblDiscountAmount.Text = string.Empty;
        //        lblTotalPrice.Text = string.Empty;
        //        lblTaxAmount.Text = string.Empty;
        //        lblTotalPrice.Text = string.Empty;
        //        txtTwoPersonQuantity.Text = string.Empty;
        //        txtfourPersonQuantity.Text = string.Empty;
        //        txtSixPersonQuantity.Text = string.Empty;
        //        cbxTwoPerson.Checked = false;
        //        cbxFourPerson.Checked = false;
        //        cbxSixPerson.Checked = false;


        //        MessageBox.Show("Your Order has been placed ");
        //    }


    }
}
