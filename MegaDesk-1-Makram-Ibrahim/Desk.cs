﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_1_Makram_Ibrahim
{
    class Desk
    {
        public double width           { get; set; }
        public double depth           { get; set; }
        public int numOfDrawers       { get; set; }
        public string deskMaterials   { get; set; }
 
    }

    enum DeskSurface
    {
        Oak = 200,
        Lanimate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }

}
