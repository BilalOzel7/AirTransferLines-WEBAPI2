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
   public interface ITransferService
    {
        IDataResult<List<Transfer>> GetAll();
        IDataResult<Transfer> GetByID(int ID);
        IResult Add(Transfer entity);
        IResult Update(Transfer entity);
        IResult Delete(Transfer entity);
        //IDataResult<List<Transfer>> GetAllByTarih(DateTime min, DateTime max);
        IDataResult<List<TransferDTO>> GetTransferDetails();
        IDataResult<List<TransferDTO>> GetTransferDetailsById(int ID);
    }
}
