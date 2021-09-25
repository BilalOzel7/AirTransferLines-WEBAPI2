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
   public interface ISurucuDal: IEntityRepository<Surucu>
    {
        List<SurucuDTO> GetSurucuDetails(Expression<Func<SurucuDTO, bool>> filter = null);
    }
}
