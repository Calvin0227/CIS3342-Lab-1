using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cis_3342_lab_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String SelectedToast = null;
            String SelectedSize = null;
            String SelectedMeal = null;
            String SelectedFill = Request.Form["Fillings"];
            String SelectedAddon = Request.Form["Addon"];
            String FirstName = Request.Form["FirstName"];
            String LastName = Request.Form["LastName"];
            String PhoneNumber = Request.Form["PhoneNumber"];
            String Drink = Request.Form["drink"];
            double Tips = int.Parse(Request.Form["Tips"].ToString());
            if (Request.Form["Toasted"] != null && Request.Form["Size"] != null && Request.Form["Meal"] != null && Request.Form["Meal"] != null)
            {
                SelectedToast = Request.Form["Toasted"].ToString();
                SelectedSize = Request.Form["Size"].ToString();
                SelectedMeal = Request.Form["Meal"].ToString();
            }

            lbl1.Text = "Thank you ! " + FirstName + "   " + LastName + " ! ";


            lbl2.Text = "We've got your oder.    Here's your order summary!";

            lbl3.Text = "Your Sandwich is : " + SelectedToast;

            lbl4.Text = "Sandwich Size Is " + SelectedSize;
            if(SelectedMeal == "Meal") 
            {
                lbl5.Text = "And Its : " + SelectedMeal + "    Drink is: " + Drink + "And One Fries!";
            }
            

            lbl6.Text = "Your Sandwich also has :    " + SelectedFill;



            //< input type = "checkbox" id = "checkbox6" class="checkbox" name="Addon" value="Sausage" /> Sausage + $1
            //<input type = "checkbox" id="checkbox7" class="checkbox" name="Addon" value="Egg" /> Egg + $0.89
            //<input type = "checkbox" id="checkbox8" class="checkbox" name="Addon" value="Tuna" /> Tuna + $1.5
            //<input type = "checkbox" id="checkbox9" class="checkbox" name="Addon" value="Chicken" /> Chicken + $1.5
            //<input type = "checkbox" id="checkbox10" class="checkbox" name="Addon" value="Steak" /> Steak + $1.5

            lbl7.Text = "Heres your Add on:    " +  SelectedAddon;

            double TotalAddon = Calculation.Math(SelectedAddon);
            
            lbl8.Text = "Tips for Maker:  $" + Tips;

            lbl9.Text = "Premium Add On Total is :  $" + TotalAddon;

            double tax = (TotalAddon + 5) * 0.06;

            lbl10.Text = "Tax Will be:  " + tax;

            double CustomerPay = 5 + TotalAddon + tax + Tips;

            lbl11.Text = "You Have To Pay : " + CustomerPay;

        }
    }
    
}