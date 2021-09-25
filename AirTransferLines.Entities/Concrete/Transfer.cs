using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
  public  class Transfer:IEntity
    {
        public int TransferID { get; set; }
        public int UlkeID { get; set; }
        public int SehirID { get; set; }
        public int AracID { get; set; }
        public int SurucuID { get; set; }
        public int DilID { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        
        public int KisiSayisi { get; set; }
        public int BagajSayisi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public int Km { get; set; }
        public string SureSaat { get; set; }
        public decimal Fiyat { get; set; }
        public decimal EkstrasızFiyat { get; set; }
        public int UserID { get; set; }
        public string Doviz { get; set; }
        public int UyeID { get; set; }
    }
}
