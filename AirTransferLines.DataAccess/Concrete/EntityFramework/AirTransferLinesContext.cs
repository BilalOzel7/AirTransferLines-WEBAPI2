using AirTransferLines.Core.Entities.Concrete;
using AirTransferLines.Entities;
using AirTransferLines.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Concrete.EntityFramework
{
   public class AirTransferLinesContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-V3FGGNT\SQLEXPRESS;Database=AirTransferLinesDB;Trusted_Connection=true");
        }

        public DbSet<Acente> Acenteler { get; set; }
        public DbSet<Surucu> Suruculer { get; set; }
        public DbSet<Transfer> Transferler { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UyeOperationClaim> UyeOperationClaims { get; set; }
        public DbSet<SurucuDestek> SurucuDestek { get; set; }





    }
}
