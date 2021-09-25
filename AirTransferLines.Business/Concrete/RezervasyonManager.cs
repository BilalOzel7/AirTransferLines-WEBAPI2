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
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public IResult Add(Rezervasyon entity)
        {
            _rezervasyonDal.Add(entity);
            return new SuccessResult(Messages.RezervasyonDeleted);
        }

        public IResult Delete(Rezervasyon entity)
        {
            _rezervasyonDal.Delete(entity);
            return new SuccessResult(Messages.RezervasyonDeleted); 
        }

        public IDataResult<List<Rezervasyon>> GetAll()
        {
            return new SuccessDataResult<List<Rezervasyon>>(_rezervasyonDal.GetAll());
        }

        public IDataResult<Rezervasyon> GetByID(int ID)
        {
            return new SuccessDataResult<Rezervasyon>(_rezervasyonDal.Get(b => b.RezervasyonID == ID));
        }

        public IResult Update(Rezervasyon entity)
        {
            _rezervasyonDal.Update(entity);
            return new SuccessResult(Messages.RezervasyonUpdated);
        }
       

        public IDataResult<List<RezervasyonDTO>> GetRezervasyonDetails()
        {
            return new SuccessDataResult<List<RezervasyonDTO>>(_rezervasyonDal.GetRezervasyonDetails());
        }

        public IDataResult<List<RezervasyonDTO>> GetRezervasyonDetailsById(int ID)
        {
            return new SuccessDataResult<List<RezervasyonDTO>>(_rezervasyonDal.GetRezervasyonDetails(c => c.RezervasyonID == ID));
        }

        public IDataResult<List<Rezervasyon>> ByStatusTrue(bool status)
        {
            return new SuccessDataResult<List<Rezervasyon>>(_rezervasyonDal.GetAll(r => r.Status == true == status));
        }

        public IDataResult<List<Rezervasyon>> ByStatusFalse(bool status)
        {
            return new SuccessDataResult<List<Rezervasyon>>(_rezervasyonDal.GetAll(r => r.Status == false == status));
        }
    }
}
