using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // temel voidler icin baslangic
    public interface IResult
    {
        // get sadece okunabilir
        // set sadece degistirilebilir
        
        // işlem sonucu bilgilendirme
        string Message { get; }
        // sonuc başarılı mı degil mi - true,false
        bool Success { get; }
    }
}
