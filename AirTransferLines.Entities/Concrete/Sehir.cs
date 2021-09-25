using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Sehir:IEntity
    {
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        public int PlakaKod { get; set; }

    }
}
