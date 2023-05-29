using System;
using System.Timers;

namespace TBD_FarmingGame_Abakus
{
    public class Tile
    {
        public bool IsTilled { get; set; }
        public bool IsWatered { get; set; }
        public bool IsSeeded { get; set; }
        public bool IsHarvested { get; set; }
        public bool IsNormal { get; set; }
        public bool IsCropReady { get; set; }




        public Tile()
        {
            IsTilled = false;
            IsWatered = false;
            IsSeeded = false;
            IsHarvested = false;
            IsNormal = true;
            IsCropReady = false;




        }
    }
}
