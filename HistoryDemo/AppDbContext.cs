//using HistoryDemo.Entities;
using Microsoft.EntityFrameworkCore;
using ModelEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryDemo
{
    public class AppDbContext : DbContext
    {
        public DbSet<BasicInformation> BasicInformations { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Initialization> Initializations { get; set; }

        public AppDbContext() : base()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        private async Task SaveDemo()
        {
            var context = new AppDbContext();
            await context.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=E:\大学课程文件\毕业设计\Experimental code\HistoryDemo\HistoryDemo\history.db");
        }
    }
}
