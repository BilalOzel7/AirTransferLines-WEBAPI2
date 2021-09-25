using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities.DTOs
{
   public class AcenteDTO
    {
        public int AcenteID { get; set; }
        public string AcenteAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string FirmaUnvan { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public int SehirID { get; set; }
        public int UlkeID { get; set; }
        public int Sozlesme { get; set; }
      
        public string Notlar { get; set; }
       
        public string FaturaAdres { get; set; }
        public string Iban { get; set; }
        public string VergiDaire { get; set; }
        public string VergiDaireNo { get; set; }
        public string YetkiliTel { get; set; }
        public string YetkiliEmail { get; set; }
        public decimal Kredi { get; set; }
        public string UlkeAdi { get; set; }
        public string SehirAd { get; set; }
        
    }
}
