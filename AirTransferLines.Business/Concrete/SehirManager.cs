using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Constants;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class SehirManager : ISehirService
    {
        ISehirDal _sehirDal;

        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public IResult Add(Sehir entity)
        {
            _sehirDal.Add(entity);
            return new SuccessResult(Messages.SehirAdded);
        }

        public IResult Delete(Sehir entity)
        {
            _sehirDal.Delete(entity);
            return new SuccessResult(Messages.SehirDeleted);
        }

        public IDataResult<List<Sehir>> GetAll()
        {
            return new SuccessDataResult <List<Sehir>>(_sehirDal.GetAll());
        }

        public IDataResult<Sehir> GetByID(int ID)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.Get(a => a.SehirID == ID));
        }

        public IResult Update(Sehir entity)
        {
            _sehirDal.Update(entity);
            return new SuccessResult(Messages.SehirUpdated);
        }
    }
}
