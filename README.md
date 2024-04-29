![f3](https://github.com/enmertkaya/OnionCarRes/assets/151652097/87a88ada-2ec5-4db3-9270-c68ce913140a)OnionCarRes isimli projem, araç kiralama deneyimini kolaylaştıran yenilikçi bir çevrimiçi platformdur. C#, MsSQL ve Bootstrap gibi güçlü programlama dilleri ve teknolojileri kullanılarak geliştirilen bu platform, kullanıcıların araç kiralamalarını hızlı ve güvenilir bir şekilde gerçekleştirmelerini sağlar.

Bu platformun temel amacı, kullanıcıların istedikleri aracı seçip kiralamalarını sağlamakla birlikte, araçları istedikleri lokasyonlara bırakarak işlemlerini tamamlamalarını da mümkün kılar. Kullanıcı dostu arayüzü sayesinde, araç kiralama süreci daha da kolaylaşır ve kullanıcılar rahatça istedikleri aracı bulup kiralamaya odaklanabilirler.

OnionCarRes'de kullanılan teknolojiler arasında JWT ve SignalR gibi güvenlik ve iletişim teknolojileri bulunmaktadır. Ayrıca, Fluent Validation kullanılarak geliştirilen platform, kullanıcıların girdikleri verilerin doğruluğunu kontrol eder ve güvenli bir kullanıcı deneyimi sunar.

Bu proje, CQRS, Mediator ve Repository Design Pattern gibi tasarım desenlerini temel alarak geliştirilmiş bir Onion Architecture projesidir. Bu sayede, platformun geliştirilmesi ve bakımı daha kolay ve etkili hale gelir.

OnionCarRes, sadece araç kiralamakla kalmaz, aynı zamanda kullanıcıların bloglarını paylaşabilecekleri, yorum bırakabilecekleri ve yöneticilerin de kolayca yönetebileceği bir admin paneline sahiptir. Proje detaylarına aşşağıda bulunan görseller ve açıklamalar ile yer vereceğim.
![f1](https://github.com/enmertkaya/OnionCarRes/assets/151652097/f1ea1666-6b8a-4321-8bbc-00f14b0e0290)

1) Bu sayfada filtreleme işlemi ile seçilen konumdan alınabilecek uygun araçlar listelenir.Örneğin Sabiha Gökçen Havalimanı ve tarih aralıkları girildiğinde o konumdan alamabilcek araçlar Uygun araçları listeleye basıldıktan sonra bu şekilde gösterilir.

![f2](https://github.com/enmertkaya/OnionCarRes/assets/151652097/d41667f9-43d2-4d88-bc12-8dc74908454d)

Sabiha Gökçen Havalimanına ait uygun araçlar : 
![f3](https://github.com/enmertkaya/OnionCarRes/assets/151652097/66f7d93c-d72b-4053-86ee-c5ef771119d5)


Filtreleme değiştirilip Ankara-AŞTİ seçildiğinde ise tek aracın geldiği gözlenir.
![f4](https://github.com/enmertkaya/OnionCarRes/assets/151652097/5c383637-396c-4e05-9142-c8c5f60a84ae)
