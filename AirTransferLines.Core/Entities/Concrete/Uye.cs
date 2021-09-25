using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core.Entities.Concrete
{
   public class Uye:IEntity
    {
        public int UyeID { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public int SehirID { get; set; }
        public int UlkeID { get; set; }
    }
}
