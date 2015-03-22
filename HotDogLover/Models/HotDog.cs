using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotDogLover.Models
{
    public class HotDog
    {
        public string HotDogName { get; set; }
        public DateTime LastTimeAte { get; set; }
        public string LastPlaceAte { get; set; }
        public int Rating { get; set; }

    }
}
