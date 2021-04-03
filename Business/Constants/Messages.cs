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
        public static string CarAdded = "Araba Eklendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string UserAdded = "User Eklendi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string CustomerAdded = "Müşteri Eklendi";

        public static string NameInvalid = "Geçersiz Isim";
        public static string Listed="Listeleme başarılı";
     
        public static string SuccessUpdate = "Update Başarılı";
        public static string SuccessAdded = "Ekleme Başarılı";
        public static string SuccessDeleted = "Silme Başarılı";

        public static string ListedCarDetail="Araç Detayları Listelendi";
        public static string ListedByBrandId="Marka Id ye Göre Listelendi";
        public static string Maintance = "Bakım Zamanı";
        public static string AuthorizationDenied="Erişim reddedildi";
        public static string UserRegistered="kayıt olundu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="şifre hatalı";
        public static string SuccessfulLogin="giriş başarışı";
        public static string UserAlreadyExists="kullanıcı var";
        public static string AccessTokenCreated="token oluşturuldu";
    }
}
