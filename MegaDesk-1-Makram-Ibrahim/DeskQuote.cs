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
        private double pWidth;
        private double pDepth;
        private int pNumOfDrawers;
        private string pMaterial;
        private string pClientName;
        private int pRushDays;

        // Fixed values that are not allowed to change
        private const double BASESIZE = 1000;
        private const double SURFACE = 1;

        /******************************
         * Overloaded Constructor
         * ***************************/
        public DeskQuote(string clientName, double width, double depth, int numOfDrawers, string material, int rushDays)
        {
            pClientName = clientName;
            pWidth = width;
            pDepth = depth;
            pNumOfDrawers = numOfDrawers;
            pMaterial = material;
            pRushDays = rushDays;
        }

        /*******************************
         * Defalut Constructor
         * ***************************/
        public DeskQuote()
        {
            pWidth = 0.0;
            pDepth = 0.0;
            pNumOfDrawers = 0;
            pMaterial = "";
            pRushDays = 0;
        }

        /***************************************
         * Accessor methods 
         * ************************************/
        public string clientName { get; set; }
        public DateTime quoteDate { get; set; }

        public DateTime geDate()
        {
            quoteDate = DateTime.Now;
            quoteDate.ToShortDateString();

            return quoteDate;
        }

        /************************************
         * Display the desk surface area
         * **********************************/
        public double getSurfaceArea()
        {
            if (pWidth * pDepth > BASESIZE)
            {
                return (pWidth * pDepth - BASESIZE) * SURFACE;
            } 
            else
            {
                return 0;
            }
        }

        /************************************
        * Get Prices 
        ***********************************/





    }
}
