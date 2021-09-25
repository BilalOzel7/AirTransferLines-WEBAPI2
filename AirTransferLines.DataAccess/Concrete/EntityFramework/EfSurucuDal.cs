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
   public class EfSurucuDal : EfEntityRepositoryBase<Surucu, AirTransferLinesContext>, ISurucuDal
    {
        public List<SurucuDTO> GetSurucuDetails(Expression<Func<SurucuDTO, bool>> filter = null)
        {
            using (AirTransferLinesContext context = new AirTransferLinesContext())
            {
                var result = from su in context.Suruculer
                             join u in context.Ulkeler
                             on su.UlkeID equals u.UlkeID
                             join se in context.Sehirler
                             on su.SehirID equals se.SehirID
                             join ac in context.Acenteler
                             on su.AcenteID equals ac.AcenteID
                             join dil in context.Diller
                             on su.DilID equals dil.DilID
                             select new SurucuDTO
                             {

                                 SurucuID = su.SurucuID,
                                 UlkeID = su.UlkeID,
                                 SehirID = su.SehirID,
                                 SehirAd = se.SehirAd,
                                 UlkeAdi = u.UlkeAdi,
                                 AcenteAd = ac.AcenteAdi,
                                 SurucuAdi=su.SurucuAdi,
                                 EMail=su.EMail,
                                 Telefon=su.Telefon,
                                 Plaka=su.Plaka,
                                 KayıtTarih=su.KayıtTarih,
                                 SonLogin=su.SonLogin,
                                 TcKimlikNo=su.TcKimlikNo,
                                 Adres=su.Adres,
                                 Sifre=su.Sifre,
                                 SurucuTip=su.SurucuTip,
                                 SurucuKomisyon=su.SurucuKomisyon,
                                 Sozlesme=su.Sozlesme,
                                 SozlesmeOnayTarih=su.SozlesmeOnayTarih,
                                 VergiDaire=su.VergiDaire,
                                 VergiDaireNo=su.VergiDaireNo,
                                 Iban=su.Iban,
                                 FaturaBilgisi=su.FaturaBilgisi,
                                 Kredi=su.Kredi,
                                 Notlar=su.Notlar,
                                 DilAdi=dil.DilAdi,
                                 DilID=su.DilID,
                                 AcenteID=su.AcenteID
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
