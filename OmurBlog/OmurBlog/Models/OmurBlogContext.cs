using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OmurBlog.Models
{
    public class OmurBlogContext : DbContext
    {
        public DbSet<Makaleler> makaleler { get; set; }
    }
}