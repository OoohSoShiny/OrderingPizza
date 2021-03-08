using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();

        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[] { checkBoxHackfleisch, checkBoxSalami, checkBoxSchinken,
            checkBoxSpinat, checkBoxOliven, checkBoxPaprika, checkBoxZwiebeln, checkBoxThunfisch, checkBoxPepperoni};
            
            int radioButtonChecked = 0;
            int boxesChecked = 0;
            
            double smallPizza = 4.60; double smallMultiplier = 1.00;
            double mediumPizza = 5.70; double mediumMultiplier = 1.20;
            double largePizza = 12.50; double largeMultiplier = 2.00;

            foreach(CheckBox checkboxCounter in checkBoxes)
            {
                if(checkboxCounter.Checked)
                { boxesChecked++; }
            }

            if (radioButtonSmall.Checked)
            { radioButtonChecked = 1; }
            else if (radioButtonMedium.Checked)
            { radioButtonChecked = 2; }
            else if (radioButtonLarge.Checked)
            { radioButtonChecked = 3; }
            
            
            switch(radioButtonChecked)
            {
                case 1:
                    PriceCalculator(smallPizza, smallMultiplier, boxesChecked);
                    break;

                case 2:
                    PriceCalculator(mediumPizza, mediumMultiplier, boxesChecked);
                    break;

                case 3:
                    PriceCalculator(largePizza, largeMultiplier, boxesChecked);
                    break;

                default:
                    lblCostNumber.Text = "Please choose a size";
                    break;
            }
        }
        private void PriceCalculator(double basePrice, double multiplier, int boxesChecked)
        {
            double endPrice = basePrice + multiplier * boxesChecked;
            lblCostNumber.Text = endPrice.ToString();           
        }
    }
}
