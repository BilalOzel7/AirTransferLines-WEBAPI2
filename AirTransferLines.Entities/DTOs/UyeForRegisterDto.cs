using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities.DTOs
{
   public class UyeForRegisterDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public int UlkeID { get; set; }
        public int SehirID { get; set; }

        public string Adres { get; set; }
        public string Telefon { get; set; }

    }
}
