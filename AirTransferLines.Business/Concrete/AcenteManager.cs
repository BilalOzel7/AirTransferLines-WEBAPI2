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
    public class AcenteManager : IAcenteService
    {
        IAcenteDal _acenteDal;
        public AcenteManager(IAcenteDal acenteDal )
        {
            _acenteDal = acenteDal;
        }
        public IResult Add(Acente acente)
        {
            _acenteDal.Add(acente);
            return new SuccessResult(Messages.AcenteAdded);
        }

        public IResult Delete(Acente entity)
        {
            _acenteDal.Delete(entity);
            return new SuccessResult(Messages.AcenteDeleted);
        }

        public IDataResult<List<AcenteDTO>> GetAll()
        {
            return new SuccessDataResult<List<AcenteDTO>>(_acenteDal.GetAcenteDetails());
        }

        public  IDataResult<Acente> GetByID(int ID)
        {
            return new SuccessDataResult<Acente>(_acenteDal.Get(a => a.AcenteID == ID));
        }

        public IDataResult<List<AcenteDTO>>  GetAcenteDetails()
        {
            return new SuccessDataResult<List<AcenteDTO>>(_acenteDal.GetAcenteDetails());
        }

        public IResult Update(Acente entity)
        {
            _acenteDal.Update(entity);
            return new SuccessResult(Messages.AcenteUpdated); 
        }

        public IDataResult<List<AcenteDTO>> GetAcenteDetailsById(int ID)
        {
            return new SuccessDataResult<List<AcenteDTO>>(_acenteDal.GetAcenteDetails(c => c.AcenteID == ID));
        }
    }
}
