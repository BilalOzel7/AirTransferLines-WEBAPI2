

using AirTransferLines.Core.Entities.Concrete;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IUyeService
    {
        
        IDataResult<Uye> GetByID(int ID);
        IResult Add(Uye entity);
        IResult Update(Uye entity);
        IResult Delete(Uye entity);
        IDataResult<List<UyeDTO>> GetUyeDetails();
        List<OperationClaim> GetClaims(Uye user);
        Uye GetByMail(string email);


    }
}
