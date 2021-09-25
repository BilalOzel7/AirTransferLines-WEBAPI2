using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities.DTOs
{
   public class UyeDTO
    {
        public int UyeID { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public int SehirID { get; set; }
        public int UlkeID { get; set; }
        public string SehirAd { get; set; }
        public string UlkeAd { get; set; }
    }
}
