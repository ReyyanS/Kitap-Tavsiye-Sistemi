KİTAP DEĞERLENDİRDİRME VE TAVSİYE SİSTEMİ
--------------------------------------------------------------------------------------------------
Kullanılacak Platformlar:
SQL Express veya Server, C#
--------------------------------------------------------------------------------------------------
Veritabanı Tasarımı: 
- Yönetici Tanım Tablosu
- Kullanıcılar Tanım Tablosu
- Yazarlar Tanım Tablosu
- Kitaplar Tanım Tablosu (Kitap Bilgileri, YazarID vs...)
- Kitap Alıntı Tablosu (KullaniciID,KitapID,SayfaNo,Cumle)
- Kitap İnceleme Tablosu (KullaniciID,KitapID,İnceleme)
- KitapOkunma Tablosu (KullanıcıID, kitapID)
- KitapPuan Tablosu (KullanıcıID, KitapID, Puan)
- Mesajlar Tablosu (GönderenID, GidenID, Baslik, Mesaj, Tarih)
- Bütün veriler veritabanında tutulacaktır.
--------------------------------------------------------------------------------------------------
Yönetici Modülü (Web Application)
- Kullanıcı adı ve şifresi ile giriş (Yönetici tanım tablosundaki kullanıcı adı şifreyle karşılaştıracak) 
- Kitap tanımları (Ekle/Sil/Düzenle) (Kitaplar Tanım Tablosuna girecek) 
--------------------------------------------------------------------------------------------------
Kullanıcı Modülü (Web Application) 
-Kullanıcı Kayıt (İsim Soyisim cinsiyet dogum tarihi kullanıcı adı şifre gibi bilgilerin alınması ve kullanıcılar tablosuna kaydı, resim yuklenmesi) 
- Kullanıcı adı ve şifresi ile giriş (Kullanıcılar tanım tablosundaki kullanıcı adı şifreyle karşılaştıracak) 
-Sisteme başarılı bir şekilde giriş yapılmışsa yanda bir menü gelecek ve orta bölümde de tavsiye sistemi çalışacak.
- Yan Menüde Kitap arama, Başka Kullanıcı Arama, Yazar Arama, Popüler kitaplar, Yüksek Puanlı kitaplar, Popüler Yazarlar linkleri olacak
--------------------------------------------------------------------------------------------------
* Popüler Kitaplar: En çok okunan kitaplar listeleceki kitaplar ve yanlarında okunma sayıları, kitaba tıklayınca kitap detayına gidecek
* Yüksek Puanlı Kitaplar: En yüksek puan verilen kitaplar ve ortalama puanları, kitaba tıklayınca kitap detayına gidecek 
* Popüler Yazarlar: Kitaplarının okunma sayısına göre en çok okunan yazarlar (YazarID'ye gore gruplama yaparak), yazara tıklayınca yazarın kitapları listelenecek, kitaba tıklayınca kitap detayına gidecek 
* Yazar Arama: Bir metin kutusuna girilen kelimeyi yazar adı soyadı bölümünde içeren yazarlar listelenir ve yazara tıklayınca yazar detay sayfasına gider
* Yazar Detay: Yazar adı soyadı, doğum tarihi, doğum yeri, ölüm tarihi (varsa), Yazarın kitapları listelenir, kitaba tıklayınca kitap detay sayfasına gider. 
* Kitap Arama: Bir metin kutusuna girilen kelimeyi başlık bölümünde içeren kitaplar listelenir ve kitaba tıklayınca kitap detay sayfasına gidecek 
--------------------------------------------------------------------------------------------------
Kitap Detay Sayfası 
-Kitaba ait kitabın ismi
- Resmi 
- Yazarı
- Yayınevi 
- Kitap tanıtım bilgisi
- Kitabın ortalama puanı
- Okunma Sayısı 
- Kitapla ilgili yapılan incelemelerin listelenmesi
- Alıntıların listelenmesi
- Kitap kaydı butonu yada linki

--------------------------------------------------------------------------------------------------
Kitap kaydı
- Bu kitabı okudum diye belirtme 
- Bu kitaba inceleme yazma 
- Kitaptan alıntı yapma 
--------------------------------------------------------------------------------------------------
