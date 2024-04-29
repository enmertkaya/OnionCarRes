OnionCarRes isimli projem, araç kiralama deneyimini kolaylaştıran yenilikçi bir çevrimiçi platformdur. C#, MsSQL ve Bootstrap gibi güçlü programlama dilleri ve teknolojileri kullanılarak geliştirilen bu platform, kullanıcıların araç kiralamalarını hızlı ve güvenilir bir şekilde gerçekleştirmelerini sağlar.

Bu platformun temel amacı, kullanıcıların istedikleri aracı seçip kiralamalarını sağlamakla birlikte, araçları istedikleri lokasyonlara bırakarak işlemlerini tamamlamalarını da mümkün kılar. Kullanıcı dostu arayüzü sayesinde, araç kiralama süreci daha da kolaylaşır ve kullanıcılar rahatça istedikleri aracı bulup kiralamaya odaklanabilirler.

OnionCarRes'de kullanılan teknolojiler arasında JWT ve SignalR gibi güvenlik ve iletişim teknolojileri bulunmaktadır. Ayrıca, Fluent Validation kullanılarak geliştirilen platform, kullanıcıların girdikleri verilerin doğruluğunu kontrol eder ve güvenli bir kullanıcı deneyimi sunar.

Bu proje, CQRS, Mediator ve Repository Design Pattern gibi tasarım desenlerini temel alarak geliştirilmiş bir Onion Architecture projesidir. Bu sayede, platformun geliştirilmesi ve bakımı daha kolay ve etkili hale gelir.

OnionCarRes, sadece araç kiralamakla kalmaz, aynı zamanda kullanıcıların bloglarını paylaşabilecekleri, yorum bırakabilecekleri ve yöneticilerin de kolayca yönetebileceği bir admin paneline sahiptir. Proje detaylarına aşşağıda bulunan görseller ve açıklamalar ile yer vereceğim.

![f1](https://github.com/enmertkaya/OnionCarRes/assets/151652097/f1ea1666-6b8a-4321-8bbc-00f14b0e0290)

1)  Bu sayfada filtreleme işlemi ile seçilen konumdan alınabilecek uygun araçlar listelenir.Örneğin Sabiha Gökçen Havalimanı ve tarih aralıkları girildiğinde o konumdan alınabilecek araçlar Uygun araçları listeleye basıldıktan sonra bu şekilde gösterilir.

![f2](https://github.com/enmertkaya/OnionCarRes/assets/151652097/d41667f9-43d2-4d88-bc12-8dc74908454d)

Sabiha Gökçen Havalimanına ait uygun araçlar : 
![f3](https://github.com/enmertkaya/OnionCarRes/assets/151652097/66f7d93c-d72b-4053-86ee-c5ef771119d5)


Filtreleme değiştirilip Ankara-AŞTİ seçildiğinde ise tek aracın geldiği gözlenir.

![f4](https://github.com/enmertkaya/OnionCarRes/assets/151652097/5c383637-396c-4e05-9142-c8c5f60a84ae)

2)  Araç listesine eklenen son 5 araç ana sayfa üzerinde bu şekilde gösterilir.

![f6](https://github.com/enmertkaya/OnionCarRes/assets/151652097/a1e11f1e-1a7c-4944-ad37-5779e90966f1)

3)  Hakkımızda ve hizmetlerimiz kısmı ;

![f8](https://github.com/enmertkaya/OnionCarRes/assets/151652097/022f12f6-9747-43c3-adc3-388336b30f09)

![f7](https://github.com/enmertkaya/OnionCarRes/assets/151652097/27cc98d7-9863-41ad-8db0-83f2702ca7da)

4)  Hizmet alan müşterilere ait yorumlar sayfada listelenir.

![f9](https://github.com/enmertkaya/OnionCarRes/assets/151652097/676fad7f-3581-4d0f-81a2-f9e13c631a5c)

5)  Sisteme kayıtlı yazarlar blog yazıları yazabilir. Bu yazılara ait farklı kullanıcılar anlık yorum bırakabilir.
Yazarlara ait bloglar :![f11](https://github.com/enmertkaya/OnionCarRes/assets/151652097/24c3406b-76f3-409f-af4d-274a1aef4f45)

Açılan blog sayfası :

![f12](https://github.com/enmertkaya/OnionCarRes/assets/151652097/b785f6f0-a2f5-42b2-83d5-57395e23b8b6)

Bu sayfaya ait bir yorum anında bırakılabilir.

![f13](https://github.com/enmertkaya/OnionCarRes/assets/151652097/5516f692-f5ad-4e8d-baa7-64dd6566725f)

6)  Footer kısmında dinamik olarak istatistiksel verilerimiz bulunmaktadır.Database ile iliskili olan bu alanda güncel verilere göre değerlerimiz değişmektedir.

![f14](https://github.com/enmertkaya/OnionCarRes/assets/151652097/a704e89a-2162-4ce8-8678-88e686114ee9)

7)  İşletmeye ait bilgilerin yer aldığı bu alanda sayfaya ait bilgiler açılır pencere şeklinde görseldeki gibi gözükmektedir.

![f16](https://github.com/enmertkaya/OnionCarRes/assets/151652097/a16dd89d-f3a7-4a14-93ec-57fe85677197)

8)  Fiyatlar sayfamız.Bu sayfayı oluştururken pivot table'dan yararlanılmıştır. PivotTable, verilerinize ilişkin karşılaştırmaları, kalıpları ve eğilimleri görmek amacıyla verileri hesaplamanıza, özetlemenize ve analiz etmenize yönelik güçlü bir araçtır.

![f17](https://github.com/enmertkaya/OnionCarRes/assets/151652097/ea9d7d3c-c132-48dc-a2d9-2be14eb5cf83)

9)  Arabalar sayfamızda , mevcut tüm araçlar bu şekilde listelenir.

![f18](https://github.com/enmertkaya/OnionCarRes/assets/151652097/1e9a88df-9681-4a40-b52e-879dbf206f4a)

10)  Araç detaylarına tıkladığımız zaman araca ait görseller ve detaylar gelir.Araç bilgileri ve araça ait teknik özellikler admin sayfasından kontrol edilebilir.Eklenip cıkarılabilir.Bu araca ait yorumlar ve acıklama kısmı admin sayfasından kontrol edilebilir.İstenilen yorumlara izin verilip yayınlanabilir.

![f19](https://github.com/enmertkaya/OnionCarRes/assets/151652097/e8ceff80-9b5b-474e-9dd6-5866934e3b8a)

Araç detaylarında bulunan hemen kirala alanından ,araca ait rezervasyon formu gelir.Dolduruldugu taktirde , bilgiler anında veri tabanında rezervasyon sayfasında gösterilecektir.Örnek bir veri girisi aşşağıda gösterilmiştir.

![f21](https://github.com/enmertkaya/OnionCarRes/assets/151652097/810c4c5e-9eec-48cd-9ad3-da5076728b2f)

11)  Sayfaya ait iletişim kısmında bulunan form doldurulursa admin sayfasından iletisime gecmek istenen kisinin bilgileri yer alır.

![f22](https://github.com/enmertkaya/OnionCarRes/assets/151652097/b0ae6d3c-4cea-40e1-9fe6-6daa281bc1a3)

12)  Sistemi kullanıcak kisiler için giriş ekranı sayfası.kullanıcı adı ve şifre yazılarak giriş yapılır.4 farklı kullanıcı rolü vardır.Yetkinlige göre sayfa yapıları ayarlanabilir.

![f23](https://github.com/enmertkaya/OnionCarRes/assets/151652097/251315eb-5842-4748-bffc-90bc43972640)

13)  Giriş yapan kullanıcı , admin paneli içinden istatistiksel veriler ve grafikleri görebilir.İstatistikler anlık olarak veritabanından güncel olarak dinamik bir şekilde alınır.

![f24](https://github.com/enmertkaya/OnionCarRes/assets/151652097/16979e46-05e8-40e3-a041-254eb865dcb7)

14)  Panel üzerinden yeni araç girişi ve bilgileri girildiğinde görseldeki sekilde liste halinde gözükür.Sag kısımda araçlara ait bloglara gelen yorumlar listelenir ve izin verilen yorumlar yayınlanır.

![f25](https://github.com/enmertkaya/OnionCarRes/assets/151652097/82ff9b3a-7eb0-48e9-bc2c-e9c41f4301b6)

15)  Firmaya ait faydalı olabilecegi düsünülen 16 adet istatistik verisi bu sayfada paylasılır.

![f26](https://github.com/enmertkaya/OnionCarRes/assets/151652097/fa9c1721-cbc8-4265-8abe-8f14aa5354ba)

16)  Araba işlemleri kısmından yeni araç eklenebilir,silinebilir.Detaylar kısmı kontrol edilebilir.Araca ait yeni bir özellik atanabilir.

![f27](https://github.com/enmertkaya/OnionCarRes/assets/151652097/fe4f1b30-314a-4205-8fbf-61596642bd06)

17)  Yorum gerçekleştirmis yazarlar panelde gözükmektedir.

![f28](https://github.com/enmertkaya/OnionCarRes/assets/151652097/671050af-e48c-4d09-b4f6-a8035b2d77e6)

18)  Blog işlemleri sayfasından kategoriye ait bilgiler gözükür ve yorumlar kısmından o bloga ait gelmis yorumlara erisilir.

![f29](https://github.com/enmertkaya/OnionCarRes/assets/151652097/6b7f1a6f-b359-4146-9cfc-4b0c530b9b9e)

19)  Ayrıca panelde yer alan diger özellikler aktif olarak kullanılabilir.SEO çalısması icin sayfalara tagcloud alanları eklenmistir. Panel istenilen dil destegi ile ceviriye uygundur.

20)  Projeye ait iliskisel veri tabanım şu şekildedir.

![f33](https://github.com/enmertkaya/OnionCarRes/assets/151652097/66236a54-9416-4020-8ca5-d233b1756dca)

21) Projeye ait detaylar commit de mevcuttur.

Kullanılan Teknolojiler;

BACKEND

C# : Backend
MsSQL : Veritabanı
Swagger : API Dökümantasyonu


FRONTEND

HTML
CSS
JavaScript
Bootstrap


Proje Yapısı & Mimarisi

Domain
Application
Persistance
Controllers
Dto's
UI


Gereksinimler

.NET Core SDK
MsSQL Server
