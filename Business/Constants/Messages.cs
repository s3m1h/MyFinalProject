using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Bakım onarımda.";
        public static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Böyle bir isimde ürün zaten var";
        public static string AuthorizationDenied = "Yetkin yok";

        public static string UserRegistered = "Kayıt oldu";

        public static string UserNotFound = "kullanıcı bulunamadı";

        public static string PasswordError = "parola hatası";

        public static string SuccessfulLogin = "başarılı giriş";

        public static string UserAlreadyExists = "";
        public static string AccessTokenCreated = "token olusturuldu";
    }
}
