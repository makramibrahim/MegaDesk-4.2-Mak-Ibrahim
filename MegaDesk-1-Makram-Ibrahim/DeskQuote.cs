using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_Makram_Ibrahim
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
        private double matPrice = 0;

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

            var date = d.ToShortDateString();

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

        /*************************************
        * Price list for desk materials
        * ***********************************/
        public double MaterialCost()
        {
            string material = desk.DeskMaterials;

            switch (material)
            {
                case "Laminate":
                    matPrice = (int)DeskSurface.Laminate;
                    break;
                case "Oak":
                    matPrice = (int)DeskSurface.Oak;
                    break;
                case "Pine":
                    matPrice = (int)DeskSurface.Pine;
                    break;
                case "Rosewood":
                    matPrice = (int)DeskSurface.Rosewood;
                    break;
                case "Veneer":
                    matPrice = (int)DeskSurface.Veneer;
                    break;
                default: 
                    matPrice = 0;
                    break;
            }

            return matPrice;

        }

        /************************************
        * Get Prices 
        ***********************************/
        public double QuoteTotal()
        {
            return BASE_PRICE + SurfaceArea() + DrawerCost() + MaterialCost() + RushOrderCost(); 
        }

        public double DrawerCost()
        {
            return (desk.NumOfDrawers * DRAWER_PRICE); 
        }

        /************************************
        * Get Rush Days cost. 
        ***********************************/
        public void RushOrderCost(string rushDays)
        {
            if (Surface < BASE_SIZE)
            {
                if (RushDays == RUSH_DAY1)
                {
                    rushDays = 60;
                }
                else if (RushDays == RUSH_DAY2)
                {
                    rushDays = 40;
                } 
                else if (RushDays == RUSH_DAY3)
                {
                    rushDays = 30;
                }
                else
                {
                    rushDays = 0;
                }
            } 
            else if (Surface > BASE_SIZE || Surface < 2000)
            {
                if (RushDays == RUSH_DAY1)
                {
                    rushDays = 70;
                }
                else if (RushDays == RUSH_DAY2)
                {
                    rushDays = 50;
                }
                else if (RushDays == RUSH_DAY3)
                {
                    rushDays = 35;
                }
                else
                {
                    rushDays = 0;
                }
            }

            else
            {
                if (RushDays == RUSH_DAY1)
                {
                    rushDays = 80;
                }
                else if (RushDays == RUSH_DAY2)
                {
                    rushDays = 60;
                }
                else if (RushDays == RUSH_DAY3)
                {
                    rushDays = 40;
                }
                else
                {
                    rushDays = 0;
                }
            }
            
        }

    }
}
