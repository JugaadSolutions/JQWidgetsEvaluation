using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restarunt> Restarunts { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

    }
}