
 using Projekt_dotNET_rzeczy_do_oddania_ML_JR.Models;
using Microsoft.EntityFrameworkCore;

 
        public class BazaDanych : DbContext
        {
    public BazaDanych(DbContextOptions options) : base(options) { }

    public DbSet<Dane> Dane { get; set; }
        }
    

