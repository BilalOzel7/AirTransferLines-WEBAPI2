using AirTransferLines.Core.Entities.Concrete;
using AirTransferLines.Core.Security.JWT;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface IAuthService
    {
        IDataResult<Uye> Register(UyeForRegisterDto userForRegisterDto, string password);
        IDataResult<Uye> Login(UyeForLoginDto userForLoginDto);
        //IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Uye user);
    }
}
