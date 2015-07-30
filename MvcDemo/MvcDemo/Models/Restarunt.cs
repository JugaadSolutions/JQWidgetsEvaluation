using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Restarunt
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<RestaurantReview> Reviews { get; set; }

    }
}