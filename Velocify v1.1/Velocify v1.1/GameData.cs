using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velocify_v1._1
{
    public class GameData
    {
            public int id { get; set; }
            public string name { get; set; }
            public string coverUrl { get; set; }

            public string genre { get; set; }

    }

    public class Cover
    {
        public string url { get; set; }
    }
}
