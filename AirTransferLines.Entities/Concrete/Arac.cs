using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Arac:IEntity
    {
        public int AracID { get; set; }
        public int AracSayisi { get; set; }
        public string AracAdi { get; set; }
        public string AracResim { get; set; }
        public int Durum { get; set; }
        public int Sira { get; set; }
        public int Bagaj { get; set; }
    }
}
