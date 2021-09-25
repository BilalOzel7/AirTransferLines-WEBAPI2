using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities.DTOs
{
   public class RezervasyonDTO
    {
        public int RezervasyonID { get; set; }
        public int UyeID { get; set; }
        public int AcenteID { get; set; }
        public DateTime KayıtTarih { get; set; }
        public decimal Fiyat { get; set; }
        public decimal EkstrasızFiyat { get; set; }
        public decimal TlFiyat { get; set; }
        public decimal EkstrasızTlFiyat { get; set; }
        public string Doviz { get; set; }
        public decimal EuroKur { get; set; }
        public decimal UsdKur { get; set; }
        public decimal IndirimliFiyat { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string AcenteAd { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Rota { get; set; }
    }
}
