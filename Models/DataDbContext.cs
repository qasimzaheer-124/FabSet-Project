using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace FabSet_Project.Models
{
    public class DataDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Signup> Signup { get; set; } // add your data models
    }
}
