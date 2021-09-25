using AirTransferLines.Core.DataAccess.EntityFramework;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Concrete.EntityFramework
{
   public class EfAcenteDal : EfEntityRepositoryBase<Acente, AirTransferLinesContext>, IAcenteDal
    {
        public List<AcenteDTO>  GetAcenteDetails(Expression<Func<AcenteDTO, bool>> filter = null)
        {
            using (AirTransferLinesContext context = new AirTransferLinesContext())
            {
                var result = from ac in context.Acenteler
                             join u in context.Ulkeler
                             on ac.UlkeID equals u.UlkeID
                             join se in context.Sehirler
                             on ac.SehirID equals se.SehirID
                             
                             select new AcenteDTO
                             {

                                 AcenteID = ac.AcenteID,
                                 UlkeID = ac.UlkeID,
                                 SehirID = ac.SehirID,
                                 SehirAd = se.SehirAd,
                                 UlkeAdi = u.UlkeAdi,
                                 Email=ac.Email,
                                 AcenteAdi=ac.AcenteAdi,
                                 Adres=ac.Adres,
                                 FaturaAdres=ac.FaturaAdres,
                                 Iban=ac.Iban,
                                 FirmaUnvan=ac.FirmaUnvan,
                                 Yetkili=ac.Yetkili,
                                 Telefon=ac.Telefon,
                                 YetkiliTel=ac.YetkiliTel,
                                 YetkiliEmail=ac.YetkiliEmail,
                                 Sozlesme=ac.Sozlesme,
                                 
                                 Notlar=ac.Notlar,
                                 
                                 VergiDaire=ac.VergiDaire,
                                 VergiDaireNo=ac.VergiDaireNo,
                                 Kredi=ac.Kredi,
                                 Sifre=ac.Sifre,
                                 
                                 
                                 
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
