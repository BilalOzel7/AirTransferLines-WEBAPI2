using AirTransferLines.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface ISurucuDestekService
    {
        IDataResult<List<SurucuDestek>> GetAll();
        IDataResult<SurucuDestek> GetByID(int ID);
        IResult Add(SurucuDestek entity);
        IResult Update(SurucuDestek entity);
        IResult Delete(SurucuDestek entity);
    }
}
