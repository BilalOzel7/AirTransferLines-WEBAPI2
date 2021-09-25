using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Ulke:IEntity
    {
        public int UlkeID { get; set; }
        public int UlastirmaUlkeID { get; set; }
        public string IkiliKod { get; set; }
        public string UcluKod { get; set; }
        public string UlkeAdi { get; set; }
        public string TelKodu { get; set; }
        public int  Sira { get; set; }

    }
}
