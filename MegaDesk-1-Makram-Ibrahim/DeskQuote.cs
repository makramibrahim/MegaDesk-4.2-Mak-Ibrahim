using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1_Makram_Ibrahim
{
    class DeskQuote
    {
        /**************************
        * Declare some variables 
        *************************/
        public string ClientName    { get; set;  }
        public int RushDays         { get; set;  }
        public int GetQuote         { get; set;  }
        private Desk desk = new Desk();

        private double Surface = 0;

        //Priced items with fiexed values
        private const double BASE_SIZE = 1000;
        private const double BASE_PRICE = 200; // Base Desk Price
        private const double DRAWER_PRICE = 50; // per drawer
        private const double SURFACE_PER_INCH = 1; // Desktop Surface Area > 1000 in2
        private const int RUSH_DAY1 = 3;
        private const int RUSH_DAY2 = 5;
        private const int RUSH_DAY3 = 7;
        private const int RUSH_HOLD = 2000;


        /******************************
         * Overloaded Constructor
         * ***************************/
        public DeskQuote(string clientName, double width, double depth, int numOfDrawers, string material, int rushDays)
        {
            ClientName = clientName;
            desk.Width = width;
            desk.Depth = depth;
            desk.NumOfDrawers = numOfDrawers;
            desk.DeskMaterials = material;
            RushDays = rushDays;

            Surface = desk.Width * desk.Depth;
        }

        /*******************************
         * Defalut Constructor
         * ***************************/
        public DeskQuote() {}

        /***************************************
         * Accessor methods 
         * ************************************/
        public string geDate()
        {
            DateTime d = DateTime.Now;

            string date = d.Month.ToString() + d.Date.ToString() + d.Year.ToString();

            return date;
        }

        /************************************
         * Display the desk surface area
         * **********************************/
        public double SurfaceArea()
        {
            if (desk.Width * desk.Depth > BASE_SIZE)
            {
                return (desk.Width * desk.Depth - BASE_SIZE) * SURFACE_PER_INCH;
            } 
            else
            {
                return 0;
            }
        }

        /************************************
        * Get Prices 
        ***********************************/
        public double QuoteTotal()
        {
            return BASE_PRICE + SurfaceArea() + DrawerCost() + int.Parse(desk.DeskMaterials) + RushOrderCost(); 
        }

        public double DrawerCost()
        {
            return (desk.NumOfDrawers * DRAWER_PRICE); 
        }

        public int RushOrderCost()
        {
            return 0;
        }




    }
}
