using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MavelApi.Models
{
    public class Comics
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UPC { get; set; }
        public string URL { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
    }
}
