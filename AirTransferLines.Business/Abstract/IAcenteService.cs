using AirTransferLines.Core.Entities;
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
   public interface IAcenteService
    {
        IDataResult<List<AcenteDTO>> GetAll();
        IDataResult<Acente>  GetByID(int ID);
        IResult Add(Acente entity);
        IResult Update(Acente entity);
        IResult Delete(Acente entity);
        IDataResult<List<AcenteDTO>>  GetAcenteDetails();
        IDataResult<List<AcenteDTO>> GetAcenteDetailsById(int ID);
    }
}
