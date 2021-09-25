using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core.Security.JWT
{//appsettings.json daki TokenOptions section ı
        public class TokenOptions
        {
            public string Audience { get; set; }
            public string Issuer { get; set; }
            public int AccessTokenExpiration { get; set; }
            public string SecurityKey { get; set; }
        }
    
}
