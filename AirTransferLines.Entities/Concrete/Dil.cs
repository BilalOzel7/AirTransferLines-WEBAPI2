using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Dil:IEntity
    {
        public int DilID { get; set; }
        public string DilKod { get; set; }
        public string Bayrak { get; set; }
        public string DilAdi { get; set; }
        

    }
}
