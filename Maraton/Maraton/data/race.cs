using System;
using System.Collections.Generic;

namespace Maraton.data
{
    public class race
    {
        public int id { get; set; }
        public string race_name { get; set; }
    }

    public class RaceCollection{
        public race[] races { get; set; }
    }
}
