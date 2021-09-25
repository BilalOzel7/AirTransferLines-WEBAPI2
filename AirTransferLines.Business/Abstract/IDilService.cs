using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IDilService
    {
        IDataResult<List<Dil>> GetAll();
        IDataResult<Dil> GetByID(int ID);
        IResult Add(Dil entity);
        IResult Update(Dil entity);
        IResult Delete(Dil entity);
    }
}
