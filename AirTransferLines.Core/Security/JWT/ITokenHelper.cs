
using AirTransferLines.Core.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core.Security.JWT
{
   public interface ITokenHelper
    {//Kullanıcıya göre ve Claimlerine göre (admin gibi) AcssesToken oluştururuz
        AccessToken CreateToken(Uye user,List<OperationClaim> operationClaims);
    }
}
