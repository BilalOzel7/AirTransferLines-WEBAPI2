using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface ISehirService
    {
        IDataResult<List<Sehir>> GetAll();
        IDataResult<Sehir> GetByID(int ID);
        IResult Add(Sehir entity);
        IResult Update(Sehir entity);
        IResult Delete(Sehir entity);
    }
}
