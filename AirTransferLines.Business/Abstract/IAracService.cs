using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IAracService
    {
        IDataResult<List<Arac>> GetAll();
        IDataResult<Arac> GetByID(int ID);
        IResult Add(Arac entity);
        IResult Update(Arac entity);
        IResult Delete(Arac entity);
    }
}
