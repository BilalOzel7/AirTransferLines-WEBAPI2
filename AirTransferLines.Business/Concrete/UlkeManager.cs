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
    public class UlkeManager : IUlkeService
    {
        IUlkeDal _ulkeDal;

        public UlkeManager(IUlkeDal ulkeDal)
        {
            _ulkeDal = ulkeDal;
        }

        public IResult Add(Ulke entity)
        {
            _ulkeDal.Add(entity);
            return new SuccessResult(Messages.UlkeAdded);
        }

        public IResult Delete(Ulke entity)
        {
            _ulkeDal.Delete(entity);
            return new SuccessResult(Messages.UlkeDeleted);
        }

        public IDataResult< List<Ulke>> GetAll()
        {
            return new SuccessDataResult< List<Ulke>>(_ulkeDal.GetAll());
        }

        public IDataResult<Ulke> GetByID(int ID)
        {
            return new SuccessDataResult<Ulke>(_ulkeDal.Get(a => a.UlkeID == ID));
        }

        public IResult Update(Ulke entity)
        {
            _ulkeDal.Update(entity);
            return new SuccessResult(Messages.UlkeUpdated);
        }
    }
}
