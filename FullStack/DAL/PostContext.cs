using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PostContext : DbContext
    {
        public DbSet<Post> posts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Comment> comments { get; set; }
    }
}
