using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
 public class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductListed = "Liste Güncelleme zamanı";
        public static string UnitPriceInvelid = "geçersiz";
        public static string ProductCountOfCategoryError = "Categoride 10 dan fazla ürün bulunamaz";
        public static string ProductNameExistsError = "Aynı isimde ürün olmaz";
        internal static string CategoryLimitExceded;
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
