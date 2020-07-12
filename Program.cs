using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtDemo
{
    public class Post { 
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string BOdy { get; set; }
        public Post() { }
        public Post(string Title, string Body) {
            this.Title = Title;
            this.BOdy = Body;
            this.DatePublished = DateTime.Now;
        }
    }
    public class BlogDbContext : DbContext { 
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
