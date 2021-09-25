using AirTransferLines.Business.Abstract;
using AirTransferLines.Business.Constants;
using AirTransferLines.DataAccess.Abstract;
using AirTransferLines.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class SurucuDestekManager : ISurucuDestekService
    {

        ISurucuDestekDal _surucuDestekDal;

        public SurucuDestekManager(ISurucuDestekDal surucuDestekDal)
        {
            _surucuDestekDal = surucuDestekDal;
        }

        public IResult Add(SurucuDestek entity)
        {
            _surucuDestekDal.Add(entity);
            return new SuccessResult(Messages.AcenteAdded);
        }

        public IResult Delete(SurucuDestek entity)
        {
            _surucuDestekDal.Delete(entity);
            return new SuccessResult(Messages.AcenteAdded);
        }

        public IDataResult<List<SurucuDestek>> GetAll()
        {
            return new SuccessDataResult<List<SurucuDestek>>(_surucuDestekDal.GetAll());
        }

        public IDataResult<SurucuDestek> GetByID(int ID)
        {
            return new SuccessDataResult<SurucuDestek>(_surucuDestekDal.Get(a => a.ID == ID));
        }

        public IResult Update(SurucuDestek entity)
        {
            _surucuDestekDal.Update(entity);
            return new SuccessResult(Messages.AcenteAdded);
        }
    }
}
