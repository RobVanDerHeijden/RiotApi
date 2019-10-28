using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Position
    {
        /*  Role:   SOLO    NONE    SOLO        DUO_CARRY   DUO_SUPPORT
         *  Lane:   TOP     JUNGLE  MIDDLE    BOTTOM      BOTTOM
         */
        public string Name { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
    }
}
