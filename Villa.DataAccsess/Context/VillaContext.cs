using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.DataAccsess.Context
{
    public class VillaContext : DbContext
    {
        public VillaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Video> Videos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>().ToCollection("Banners");
            modelBuilder.Entity<Contact>().ToCollection("Contact");
            modelBuilder.Entity<Counter>().ToCollection("Counter");
            modelBuilder.Entity<Deal>().ToCollection("Deal");
            modelBuilder.Entity<Feature>().ToCollection("Feature");
            modelBuilder.Entity<Message>().ToCollection("Message");
            modelBuilder.Entity<Product>().ToCollection("Product");
            modelBuilder.Entity<Quest>().ToCollection("Quest");
            modelBuilder.Entity<Video>().ToCollection("Video");

        }
    }
}
