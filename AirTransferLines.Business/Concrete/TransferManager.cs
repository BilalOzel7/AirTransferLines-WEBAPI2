using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Constants;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class TransferManager : ITransferService
    {
        ITransferDal _transferDal;

        public TransferManager(ITransferDal transferDal)
        {
            _transferDal = transferDal;
        }

        public IResult Add(Transfer entity)
        {
            _transferDal.Add(entity);
            return new SuccessResult(Messages.TransferAdded);
        }

        public IResult Delete(Transfer entity)
        {
            _transferDal.Delete(entity);
            return new SuccessResult(Messages.TransferDeleted);
        }

        public IDataResult< List<Transfer>> GetAll()
        {
            return new SuccessDataResult<List<Transfer>>(_transferDal.GetAll());
        }

        //public List<Transfer> GetAllByTarih(DateTime min,DateTime max)
        //{
        //    return new List<Transfer>(_transferDal.GetAll(t => t.Tarih >= min && t.Tarih <= max));
        //}

        public IDataResult<Transfer> GetByID(int ID)
        {
            return new SuccessDataResult<Transfer>(_transferDal.Get(a => a.TransferID == ID));
        }

        public IDataResult< List<TransferDTO>> GetTransferDetails()
        {
            return new SuccessDataResult< List<TransferDTO>>(_transferDal.GetTransferDetails());
        }

        public IDataResult<List<TransferDTO>> GetTransferDetailsById(int ID)
        {
            return new SuccessDataResult<List<TransferDTO>>(_transferDal.GetTransferDetails(c => c.TransferID == ID));
        }

        public IResult Update(Transfer entity)
        {
            _transferDal.Update(entity);
            return new SuccessResult(Messages.TransferUpdated);
        }

        
    }
}
