using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        // token degerinin ne kadar süreyle geçerli oldugu bilgisi -- expiration
        public DateTime Expiration { get; set; }
    }
    
}
