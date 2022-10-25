using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCInAction.Models
{
    public class Movie
    {
        //prop + 2x Tab
        public String movieName { get; set; }
        public int releasedYear { get; set; }

        public String genre { get; set; }
    }
}
