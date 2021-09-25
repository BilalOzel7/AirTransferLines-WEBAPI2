using AirTransferLines.Core.Entities.Concrete;
using AirTransferLines.Core.Extensions;
using AirTransferLines.Core.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions; //config den gelen options değerlerini nesneye atıyoruz
        private DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();//config deki tokenoptions section ı al token option 
                                                                                           //nesnemize eşitle

        }
        public AccessToken CreateToken(Uye user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);//token ne zaman bitecek config den alıyor bilgiyi
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, Uye user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {//Gerekli parametreleri kullanarak jwt oluşturuyoruz.
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(Uye user, List<OperationClaim> operationClaims)
        {//ClaimExtensions classında oluşturduğumuz methodları burda kullanıyoruz.
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.UyeID.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.UyeAd} {user.UyeSoyad}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
