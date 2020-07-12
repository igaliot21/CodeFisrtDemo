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
    public class Customer {
        public int Id { get; set; }
        public int Name { get; set; }
    }
    public class Product {
        public int Id { get; set; }
        public int Name { get; set; }
    }
    public class Order {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }

    public class BlogDbContext : DbContext { 
        public DbSet<Post> Posts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
