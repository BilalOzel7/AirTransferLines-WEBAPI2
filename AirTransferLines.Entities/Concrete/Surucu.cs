using AirTransferLines.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Entities
{
   public class Surucu:IEntity
    {
        public int SurucuID { get; set; }
        public int AcenteID { get; set; }
        public int UlkeID { get; set; }
        public int SehirID { get; set; }
        public int DilID { get; set; }
        public string SurucuAdi { get; set; }
        public string EMail { get; set; }
        public string Telefon { get; set; }
        public string Plaka { get; set; }
        public DateTime KayıtTarih { get; set; }
        public DateTime SonLogin { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adres { get; set; }
        public string Sifre { get; set; }
        public int SurucuTip { get; set; }
        public int SurucuKomisyon { get; set; }
        public int Sozlesme { get; set; }
        public DateTime SozlesmeOnayTarih { get; set; }
        public string FaturaBilgisi { get; set; }
        public string Iban { get; set; }
        public string VergiDaire { get; set; }
        public string VergiDaireNo { get; set; }
        public decimal Kredi { get; set; }
        public string Notlar { get; set; }


    }
}
