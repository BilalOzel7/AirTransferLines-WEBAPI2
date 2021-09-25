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
    public class SurucuManager : ISurucuService
    {
        ISurucuDal _surucuDal;

        public SurucuManager(ISurucuDal surucuDal)
        {
            _surucuDal = surucuDal;
        }
        public IResult Add(Surucu entity)
        {
            _surucuDal.Add(entity);
            return new SuccessResult(Messages.SurucuAdded);
        }

        public IResult Delete(Surucu entity)
        {
            _surucuDal.Delete(entity);
            return new SuccessResult(Messages.SurucuDeleted);
        }

        public IDataResult<List<Surucu>> GetAll()
        {
            return new SuccessDataResult<List<Surucu>>(_surucuDal.GetAll());
        }

        public IDataResult<Surucu> GetByID(int ID)
        {
            return new SuccessDataResult<Surucu>(_surucuDal.Get(a => a.SurucuID == ID));
        }

        public IDataResult<List<SurucuDTO>> GetSurucuDetails()
        {
            return new SuccessDataResult< List<SurucuDTO>>(_surucuDal.GetSurucuDetails());
        }

        public IResult Update(Surucu entity)
        {
            _surucuDal.Update(entity);
            return new SuccessResult(Messages.SehirDeleted);
        }
    }
}
