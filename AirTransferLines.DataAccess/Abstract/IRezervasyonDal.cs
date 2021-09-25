using AirTransferLines.Core.DataAccess;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Abstract
{
   public interface IRezervasyonDal: IEntityRepository<Rezervasyon>
    {
        List<RezervasyonDTO> GetRezervasyonDetails(Expression<Func<RezervasyonDTO, bool>> filter = null);
    }
}
