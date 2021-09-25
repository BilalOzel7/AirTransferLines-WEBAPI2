using AirTransferLines.Core.DataAccess.EntityFramework;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Concrete.EntityFramework
{
    public class EfRezervasyonDal : EfEntityRepositoryBase<Rezervasyon, AirTransferLinesContext>, IRezervasyonDal
    {

        public List<RezervasyonDTO> GetRezervasyonDetails(Expression<Func<RezervasyonDTO, bool>> filter = null)
        {
            using (AirTransferLinesContext context = new AirTransferLinesContext())
            {
                var result = from re in context.Rezervasyonlar
                             join ac in context.Acenteler
                             on re.AcenteID equals ac.AcenteID
                             join uye in context.Uyeler
                             on re.UyeID equals uye.UyeID

                             select new RezervasyonDTO
                             {

                                 RezervasyonID = re.RezervasyonID,
                                 AcenteID = re.AcenteID,
                                 UyeID = re.UyeID,
                                 UyeAd = uye.UyeAd,
                                 UyeSoyad = uye.UyeSoyad,
                                 AcenteAd = ac.AcenteAdi,
                                 KayıtTarih = re.KayıtTarih,
                                 Fiyat = re.Fiyat,
                                 EkstrasızFiyat = re.EkstrasızFiyat,
                                 EkstrasızTlFiyat = re.EkstrasızTlFiyat,
                                 TlFiyat = re.TlFiyat,
                                 Doviz = re.Doviz,
                                 EuroKur = re.EuroKur,
                                 UsdKur = re.UsdKur,
                                 IndirimliFiyat = re.IndirimliFiyat,
                                 Telefon = uye.Telefon,
                                 Email = uye.Email,
                                 Rota=re.Rota




                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
    }
}
