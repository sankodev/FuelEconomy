using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public class FuelEconomy
    {
        /// <summary>
        /// 
        /// </summary>To calculate any input of milesPergallon and calculate the outcome of use and determine the soultion of time for refill.
        /// <param name="anyTextBox">the input of information for results</param>
        /// <param name="anyValue">gallons and miles</param>
        /// <param name="anyMin">starting point or if none used for value</param>
        /// <param name="anyMax">ending point or if exceeded</param>
        /// <param name="anyErrorLabel">to iterate if value input cannot result</param>
        /// <returns></returns>
        //public static bool CalculateMilesPerGallon(TextBox anyTextBox, ref double anyValue, double anyMin, double anyMax, Label anyErrorLabel)
        //{
        //    if (!double.TryParse(anyTextBox.Text, out anyValue) || anyValue < anyMin || anyValue > anyMax)
        //    {
        //        anyErrorLabel.Show();
        //        anyTextBox.Focus();
        //        anyTextBox.SelectAll();
        //        return false;
        //    }
        //    anyErrorLabel.Hide();
        //    return true;
        //}

        public static bool CalculateMilesPerGallon(double milesDriven, double gallonsUsed)
        {

            double milesPerGallon = 0;

            milesPerGallon = milesDriven / gallonsUsed;
            
            //if (!double.TryParse(anyTextBox.Text, out anyValue) || anyValue < anyMin || anyValue > anyMax)
            //{

            
            //    anyErrorLabel.Show();
            //    anyTextBox.Focus();
            //    anyTextBox.SelectAll();
            //    return false;
            //}
            //anyErrorLabel.Hide();
            return true;
        }

        public static bool MilesLeftUntilOilChange(List<double> milesDrivenList)
        {
            //double gallonsUsed = gallonsUsedTextBox.Text;
            //if (gallonsUsed > 3000)
            //{
                
            //}
            milesDrivenList = new List<double>();
            double totalMilesDriven = milesDrivenList.Count();
            double milesLeft = 0;


            milesLeft = 3000 - totalMilesDriven;

            return true;
        }
    }
}
