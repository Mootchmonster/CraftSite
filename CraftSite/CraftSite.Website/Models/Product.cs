using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftSite.Website.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }
    }
}
