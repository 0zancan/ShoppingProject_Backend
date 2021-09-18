using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Product
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı ürün adından birden fazla olamaz.";

        //General
        public static string MaintenanceTime = "Bakımda";

        //Category
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";

        public static string AuthorizationDenied = "Yetkisi yok.";
        internal static string UserRegistered = "Kullanıcı kayıt oldu.";
        internal static string UserNotFound = "Kullanıcı bulunamadı.";
        internal static string PasswordError = "Şifre hatalı.";
        internal static string SuccessfulLogin = "Giriş yapıldı.";
        internal static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        internal static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
