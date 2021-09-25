using AirTransferLines.Business.Abstract;
using AirTransferLines.Core.Entities.Concrete;
using AirTransferLines.Core.Security.Hashing;
using AirTransferLines.Core.Security.JWT;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUyeService _uyeService;
        ITokenHelper _tokenHelper;
        public AuthManager(IUyeService uyeService, ITokenHelper tokenHelper)
        {
            _uyeService = uyeService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(Uye uye)
        {
            var claims = _uyeService.GetClaims(uye);
            var accessToken = _tokenHelper.CreateToken(uye, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Giriş Yapıldı");
        }

        public IDataResult<Uye> Login(UyeForLoginDto userForLoginDto)
        {
            var userToCheck = _uyeService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Uye>("Kullanıcı bulunamadı");//Messages.UserNotFound
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Uye>("Parola hatası");//Messages.PasswordError
            }

            return new SuccessDataResult<Uye>(userToCheck, "Başarılı giriş");
        }

        public IDataResult<Uye> Register(UyeForRegisterDto uyeForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new Uye
            {
                Email = uyeForRegisterDto.Email,
                UyeAd = uyeForRegisterDto.UyeAd,
                UyeSoyad = uyeForRegisterDto.UyeSoyad,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true,
                UlkeID=uyeForRegisterDto.UlkeID,
                SehirID=uyeForRegisterDto.SehirID,
                Telefon=uyeForRegisterDto.Telefon,
                Adres=uyeForRegisterDto.Adres
            };
            _uyeService.Add(user);
            return new SuccessDataResult<Uye>(user, "Kayıt oldu");
        }

        //public IResult UserExists(string email)
        //{
        //    if (_uyeService.GetByMail(email) != null)
        //    {
        //        return new ErrorResult("Kullanıcı mevcut");//Messages.UserAlreadyExists
        //    }
        //    return new SuccessResult();
        //}

       
    }
}
