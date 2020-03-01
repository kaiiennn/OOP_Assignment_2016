//============================================================
// Student Number	: S10170878, S10173513
// Student Name	: Teo Wen Yu Carlsen, Yong Kai En
// Module  Group	: IT03
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Adult:Ticket
    {
        private bool popcornOffer;
        public bool PopcornOffer
        {
            get { return popcornOffer; }
            set { popcornOffer = value; }
        }

        public Adult() { }
        public Adult(Screening s, bool p):base(s)
        {
            PopcornOffer = p;   
        }
        public override double CalculatePrice()
        {
            double price;
            DateTime dateValue = base.Screening.ScreeningDateTime;
            string day = dateValue.ToString("dddd");
            if (base.Screening.ScreeningType=="3D")
            {
                if (day == "Friday" || day == "Saturday" || day == "Sunday")
                {
                    price = 14.00;
                }
                else
                {
                    price = 11.00;
                }
            }
            //2D
            else
            {
                if (day == "Friday" || day == "Saturday" || day == "Sunday")
                {
                    price = 12.50;
                }
                else
                {
                    price = 8.50;
                }
            }
            if (PopcornOffer==true)
            {
                price += 3.00;
            }
            return price;
        }
        public override string ToString()
        {
            return (base.ToString() + "\t" + "Popcorn Offer: " + PopcornOffer);
        }
    }
}
