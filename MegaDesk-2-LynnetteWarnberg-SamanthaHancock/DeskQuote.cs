using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_LynnetteWarnberg


{
    public class DeskQuote
    {
        //constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        const decimal RUSH_3DAY_LESS_THAN_1000 = 60.00M;
        const decimal RUSH_3DAY_1000_TO_2000 = 70.00M;
        const decimal RUSH_3DAY_GREATER_THAN_2000 = 80.00M;
        const decimal RUSH_5DAY_LESS_THAN_1000 = 40.00M;
        const decimal RUSH_5DAY_1000_TO_2000 = 50.00M;
        const decimal RUSH_5DAY_GREATER_THAN_2000 = 60.00M;
        const decimal RUSH_7DAY_LESS_THAN_1000 = 30.00M;
        const decimal RUSH_7DAY_1000_TO_2000 = 35.00M;
        const decimal RUSH_7DAY_GREATER_THAN_2000 = 40.00M;

        //Properties
        public Desk Desk { get; set; }

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Delivery DeliveryType { get; set; }

        public decimal QuoteAmount { get; set; }

        //enums
        public enum Delivery
        {
            Day3Rush,
            Day5Rush,
            Day7Rush,
            Day14NoRush

        }
        //methods
        public decimal GetQuote()

        {
            //return value
            decimal quotePrice = BASE_DESK_PRICE;

            //surface area
            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;

            //surface price
            decimal surfacePrice = 0.00M;

            if (surfaceArea > 1000)
            {
                surfacePrice = (surfaceArea - 1000) * SURFACE_AREA_COST;
            }

            var NumOfDrawersPrice = Desk.NumberOfDrawers * 50;

            var surfaceMaterialPrice = 0;
            switch (Desk.SurfaceMaterial)
            {
                case Desk.Surface.Oak:
                    surfaceMaterialPrice = 200;
                    break;

                case Desk.Surface.Laminate:
                    surfaceMaterialPrice = 100;
                    break;

                case Desk.Surface.Pine:
                    surfaceMaterialPrice = 50;
                    break;

                case Desk.Surface.Rosewood:
                    surfaceMaterialPrice = 300;
                    break;

                case Desk.Surface.Veneer:
                    surfaceMaterialPrice = 125;
                    break;
            }

            var shippingPrice = 0;
            switch (DeliveryType)
            {
                case Delivery.Day3Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 60;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 70;
                    }
                    else
                    {
                        shippingPrice = 80;
                    }
                    break;

                case Delivery.Day5Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 40;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 50;
                    }
                    else
                    {
                        shippingPrice = 60;
                    }
                    break;

                case Delivery.Day7Rush:
                    if (surfaceArea < 1000)
                    {
                        shippingPrice = 30;
                    }
                    else if (surfaceArea < 2000)
                    {
                        shippingPrice = 35;
                    }
                    else
                    {
                        shippingPrice = 40;
                    }
                    break;

                default:
                    shippingPrice = 0;
                    break;
            }

            quotePrice = 200 + surfacePrice + NumOfDrawersPrice + surfaceMaterialPrice + shippingPrice;

            return quotePrice;
        }
    }
     
  }
