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
    public class AracManager : IAracService
    {
        IAracDal _aracDal;

        public AracManager(IAracDal aracDal)
        {
            _aracDal = aracDal;
        }

        public IResult Add(Arac entity)
        {
            _aracDal.Add(entity);
            return new SuccessResult(Messages.AracAdded); ;
        }

        public IResult Delete(Arac entity)
        {
            _aracDal.Delete(entity);
            return new SuccessResult(Messages.AracDeleted); 
        }

        public IDataResult<List<Arac>> GetAll()
        {
            return new SuccessDataResult<List<Arac>>(_aracDal.GetAll());
        }

        public IDataResult<Arac> GetByID(int ID)
        {
            return new SuccessDataResult<Arac>(_aracDal.Get(a => a.AracID == ID));
        }

        public IResult Update(Arac entity)
        {
            _aracDal.Update(entity);
            return new SuccessResult(Messages.AracUpdated);
        }
    }
}
