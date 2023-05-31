using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWithMenu.Models
{
    
        [Table("tblAngularResturant")]
        public class Resturant
        {
            public int id { get; set; }
            public string Menu { get; set; } = string.Empty;
            public string Image { get; set; } = string.Empty;
            public int Price { get; set; } 
        }
        public class AngularDB : DbContext
        {
            public virtual DbSet<Resturant> Resturants { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                const string STRCONN = @"Data Source=W-674PY03-1;Initial Catalog=Himanshu1Db;Persist Security Info=True;User ID=sa;Password=Password@12345; TrustServerCertificate=true;";
                optionsBuilder.UseSqlServer(STRCONN);
            }
        }
    
}
