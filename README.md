# HotelReservationSolution
2025 Nesne Yönelimli Programlama Proje Ödevi



## Otel Otomasyon Sistemi
Bu proje, bir otel yönetim sistemi için geliştirilmiş bir otomasyon yazılımıdır. Sistem, otel rezervasyonlarının yönetilmesini, müşteri bilgilerini takip etmeyi, oda durumu izlemeyi ve daha birçok işlevi sağlamaktadır.


### Teknolojiler
C#: Uygulamanın ana programlama dili olarak kullanıldı.

MySQL: Veritabanı yönetimi ve veri saklama işlemleri için kullanıldı.

N Katmanlı Mimari: Uygulama, katmanlı mimari yaklaşımıyla modüler ve sürdürülebilir bir yapıdadır.





## LoginForm

![Image](https://github.com/user-attachments/assets/ee300ada-fbda-4163-9e4b-fee5951cab16)

Bu ekran, otel otomasyon sistemine giriş yapabilmek için kullanıcıların email ve şifre bilgilerini girmesini sağlar. Sisteme giriş yapmak için, veritabanında kayıtlı olan email ve şifre bilgileri doğru şekilde girilmelidir.

>Yanlış Bilgi Durumu: Kullanıcı yanlış email veya şifre girdiğinde, bir hata mesajı görüntülenir. Hata mesajında "Kullanıcı adı veya şifre yanlış" uyarısı gösterilir.



## MainForm

![Image](https://github.com/user-attachments/assets/4f2aebb1-e1cb-44d8-b500-86a321e5865a)

Otel yönetim sisteminin en önemli kısmıdır ve tüm işlemleri merkezi bir noktada toplayarak kullanıcıya kolay bir erişim sağlar. Oda işlemleri, rezervasyon yönetimi ve ayarlar gibi fonksiyonlar, kullanıcıların her türlü işlemi tek bir ekrandan hızlı ve verimli bir şekilde yapabilmesini sağlar. Kullanıcılar yeni rezervasyonlar ekleyebilir, mevcut rezervasyonları görüntüleyebilir ve iptal edebilirler. 
>Rezervasyon Ekle butonuna tıklandığında, kullanıcı AddReservationForm ekranına yönlendirilir ve yeni bir rezervasyon ekleyebilir. Oda İşlemleri içerisinde bulunan oda Ekle, oda düzenle ve oda sil butonları ise kullanıcıyı RoomForm pencerelerine yönlendirerek oda işlemleri yapmasına olanak sağlar. Bu akış, otel yönetimi ve rezervasyon takibini oldukça verimli ve kullanıcı dostu hale getirir.




## AddReservationForm

![Image](https://github.com/user-attachments/assets/1cc584f7-e784-4a57-9bf4-c02edf3bf939)

>Bu formda kullanıcı, yeni rezervasyon için müşteri bilgilerini, rezervasyon tarihlerini, oda tipini vb. bilgileri girer.

>Kaydet butonuna tıklanarak, bu bilgiler MainForm üzerindeki DataGridView (DGV)'ye eklenir ve sistem güncellenir.



## RoomForm

![Image](https://github.com/user-attachments/assets/83b24b0f-6a77-4b8f-8739-3d0c5de60fbf)

>Oda Ekle: Kullanıcı, oda bilgilerini ekler.

>Oda Düzenle: Var olan oda bilgilerini düzenler.

>Oda Sil: Mevcut odaları siler.

RoomForm, kullanıcıya otel odalarıyla ilgili her türlü yönetim işlemini yapabilme imkanı sağlar.




## Settings Paneli

![Image](https://github.com/user-attachments/assets/c7bd2714-59c5-49bd-88dc-01dde07d62a8)

>Şifre Değiştirme: Panelde, kullanıcılar eski şifrelerini girip yeni bir şifre belirler. Bu işlem MainForm'daki mevcut kullanıcı oturumunu güvenli bir şekilde günceller.


>Erişim: Settings simgesine tıklandığında, MainForm üzerinde bir panel açılır. Bu panelde şifre değiştirme işlemi yapılabilir. Şifre değiştirme işlemi, kullanıcının kimliğini doğrulamak amacıyla eski şifreyi girmesini gerektirir.



# UML Diyagramları

## Class Diyagramı

![Image](https://github.com/user-attachments/assets/970ff3bb-fbca-4103-b655-2a5d303f4659)









## Use-Case Diyagramı

![Image](https://github.com/user-attachments/assets/e37b01fe-54c5-479d-8d59-0e44908a99bc)







## ER Diyagramı

![Image](https://github.com/user-attachments/assets/c873fcdb-e7c3-49b4-9314-ed456c1b0877)



# Youtube 
https://www.youtube.com/watch?v=RAYOl6ouaJ4&t=9s

