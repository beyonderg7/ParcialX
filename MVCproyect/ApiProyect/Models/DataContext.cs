using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiProyect.Models
{
    public class DataContext:DbContext
    {

        public DataContext():base("DefaultConnection")
        {
                


        }

        public System.Data.Entity.DbSet<ApiProyect.Models.ChristianYabetaFriends> ChristianYabetaFriends { get; set; }
    }
}