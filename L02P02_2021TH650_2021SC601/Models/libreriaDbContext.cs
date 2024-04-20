using Microsoft.EntityFrameworkCore;
namespace L02P02_2021TH650_2021SC601.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions<libreriaDbContext> options) : base(options)
        {


        }

    }
}
