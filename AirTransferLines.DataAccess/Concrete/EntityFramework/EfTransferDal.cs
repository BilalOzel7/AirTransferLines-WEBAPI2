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
    public class EfTransferDal : EfEntityRepositoryBase<Transfer, AirTransferLinesContext>, ITransferDal
    {
        public List<TransferDTO> GetTransferDetails(Expression<Func<TransferDTO, bool>> filter = null)
        {
            using (AirTransferLinesContext context = new AirTransferLinesContext())
            {
                var result = from tr in context.Transferler
                             join u in context.Ulkeler
                             on tr.UlkeID equals u.UlkeID
                             join se in context.Sehirler
                             on tr.SehirID equals se.SehirID
                             join uye in context.Uyeler
                             on tr.UyeID equals uye.UyeID
                             join ar in context.Araclar
                             on tr.AracID equals ar.AracID
                             select new TransferDTO
                             {

                                 TransferID = tr.TransferID,
                                 UlkeID = tr.UlkeID,
                                 SehirID = tr.SehirID,
                                 SehirAd = se.SehirAd,
                                 UlkeAdi = u.UlkeAdi,
                                 UyeAd = uye.UyeAd,
                                 UyeSoyad = uye.UyeSoyad,
                                 AracAdi = ar.AracAdi,
                                 Email = uye.Email,
                                 Nereden=tr.Nereden,
                                 Nereye=tr.Nereye,
                                 KisiSayisi = tr.KisiSayisi,
                                 BagajSayisi = tr.BagajSayisi,
                                 Tarih = tr.Tarih,
                                 Saat = tr.Saat,
                                 Km = tr.Km,
                                 SureSaat = tr.SureSaat,
                                 Fiyat = tr.Fiyat,
                                 EkstrasızFiyat = tr.EkstrasızFiyat,
                                 Doviz = tr.Doviz,
                                 Telefon = uye.Telefon
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
