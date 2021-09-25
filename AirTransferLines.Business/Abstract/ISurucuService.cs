using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface ISurucuService
    {
        IDataResult<List<Surucu>> GetAll();
        IDataResult<Surucu> GetByID(int ID);
        IResult Add(Surucu entity);
        IResult Update(Surucu entity);
        IResult Delete(Surucu entity);
        IDataResult<List<SurucuDTO>> GetSurucuDetails();
    }
}
