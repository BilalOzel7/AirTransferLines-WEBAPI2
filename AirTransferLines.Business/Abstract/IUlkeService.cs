using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IUlkeService
    {
        IDataResult<List<Ulke>> GetAll();
        IDataResult<Ulke> GetByID(int ID);
        IResult Add(Ulke entity);
        IResult Update(Ulke entity);
        IResult Delete(Ulke entity);
    }
}
