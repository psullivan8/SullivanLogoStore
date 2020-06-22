//Patrik Sullivan psullivan8@cnm.edu
//Store With Properties and Constructor
//6-15-20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:Good work  score 100/100

namespace SullivanLogoStore
{
    class LogoOrderItem : LogoItemOrderForm
    {
        double Pen_Price = 1.00;
        double USB_Price = 3.50;
        double Mug_Price = 4.00;
        double Text_Price = 0.03;
        double Logo_Price = 0.10;
        double Color_Price = 0.03;
        private bool hasText;

        public LogoOrderItem(int itemID, string itemType, int numColors, int numItems, string engraveText, bool hasLogo)
        {
            ItemId = itemID;
            NumItems = numItems;
            ItemType = itemType;
            NumColors = numColors;
        }

        public LogoOrderItem(string engraveText, bool hasLogo)
        {
            HasLogo = hasLogo;
            Text = engraveText;
        }

        public LogoOrderItem()
        {
            CalcPrice();
        }

        public int ItemId { get; set; }

        public int NumItems { get; set; }

        public string ItemType { get; set; }

        public string EngraveText { get; set; }

        public bool HasLogo { get; set; }

        public int NumColors { get; set; }

        public decimal Price { get; set; }

        private void CalcPrice()
        {
            decimal price = 0;
            double itemCost = 0.0, logoCost = 0.0, colorCost = 0.0, textCost = 0.0;
            if (ItemType == "USB")
            {
                itemCost = USB_Price;
            }
            else if (ItemType == "Mug")
            {
                itemCost = Mug_Price;
            }
            else if (ItemType == "Pen")
            {
                itemCost = Pen_Price;
            }
            if (HasLogo == true)
            {
                logoCost = Logo_Price;
                colorCost = (Color_Price * NumColors);
            }
            if (!string.IsNullOrEmpty(EngraveText))
            {
                hasText = true;
                textCost = Text_Price;
            }
            price = Convert.ToDecimal(itemCost + logoCost + colorCost + textCost) * (NumItems);
            Price = price;
        }

        public string GetOrderSummary()
        {
            CalcPrice();
            string priceFormat = "";
            priceFormat = string.Format("{0:c}", Price);
            string summary =
                "Order Number: " + ItemId
                + "\r\n" + NumItems
                + " " + ItemType + "s"
                + " With " + NumColors + " Colors."
                + (hasText ? "\r\nEngrave Text: " + EngraveText : "")
                + (HasLogo ? "\r\nLogo: Yes" : "")
                + "\r\nTotal Price: " + priceFormat + ".";
            return summary;
        }
    }
}