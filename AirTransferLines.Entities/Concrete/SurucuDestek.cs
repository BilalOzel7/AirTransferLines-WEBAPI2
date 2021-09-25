using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities.Concrete
{
   public class SurucuDestek:IEntity
    {
        public int ID { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public int SurucuID { get; set; }
    }
}
