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
    public class DilManager : IDilService
    {
        IDilDal _dilDal;

        public DilManager(IDilDal dilDal)
        {
            _dilDal = dilDal;
        }

        public IResult Add(Dil entity)
        {
            _dilDal.Add(entity);
            return new SuccessResult(Messages.DilAdded);
        }

        public IResult Delete(Dil entity)
        {
            _dilDal.Delete(entity);
            return new SuccessResult(Messages.DilDeleted);
        }

        public IDataResult<List<Dil>> GetAll()
        {
            return new SuccessDataResult<List<Dil>>(_dilDal.GetAll());
        }

        public IDataResult<Dil> GetByID(int ID)
        {
            return new SuccessDataResult<Dil>(_dilDal.Get(a => a.DilID == ID));
        }

        public IResult Update(Dil entity)
        {
            _dilDal.Update(entity);
            return new SuccessResult(Messages.DilUpdated);
        }
    }
}
