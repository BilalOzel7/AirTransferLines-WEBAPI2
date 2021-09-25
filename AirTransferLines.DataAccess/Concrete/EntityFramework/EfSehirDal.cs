using AirTransferLines.Core.DataAccess.EntityFramework;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.DataAccess.Concrete.EntityFramework
{
   public class EfSehirDal : EfEntityRepositoryBase<Sehir, AirTransferLinesContext>, ISehirDal
    {
       
    }
}
