using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1_Makram_Ibrahim
{
    class Desk
    {
        public double Width           { get; set; }
        public double Depth           { get; set; }
        public int NumOfDrawers       { get; set; }
        public string DeskMaterials   { get; set; }
 
    }

    /**************************
     * Set our own data type 
     ************************/
   public enum DeskSurface
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }

}
