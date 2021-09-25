using AirTransferLines.Core.DataAccess;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Abstract
{
   public interface IAcenteDal:IEntityRepository<Acente>
    {
       List<AcenteDTO>  GetAcenteDetails(Expression<Func<AcenteDTO, bool>> filter = null);
    }
}
