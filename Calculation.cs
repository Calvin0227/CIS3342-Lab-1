using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cis_3342_lab_1
{
    public class Calculation
    {
        //public static TotalAmount TotalAmount = new TotalAmount();
        public static double Math(String selectedAddon)
        {

            double TotalAmount = 0;
            
            string[] selectVal = selectedAddon.Split(new char[1] { ',' });

            // string selectVal = SelectedAddon.split(',');

            foreach (string str in selectVal)
            {
                if (str == "Sausage")
                {
                    TotalAmount += 1;
                }
                else if (str == "Egg")
                {
                    TotalAmount += 0.89;
                }
                else if (str == "Tuna")
                {
                    TotalAmount += 1.5;
                }
                else if (str == "Chicken")
                {
                    TotalAmount += 1.5;
                }
                else if (str == "Steak")
                {
                    TotalAmount += 1.5;
                }
            }
            return TotalAmount;
        }
    }
}