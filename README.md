

# Residensea Hotel Management System

Bu proje, .NET Core 7, Web API, N-tier architecture ve Repository Design Pattern kullanılarak ve Code First yaklaşımıyla geliştirilmiş bir otel yönetim sistemidir. Ayrıca, Mail servisleri ve Identity kütüphanesi de entegre edilmiştir. Projede, müşteri yönetimi, oda rezervasyonları, personel takibi gibi temel otel işlemleri bulunmaktadır.

![1](https://github.com/emreylmz7/HotelApp/assets/65964414/63e3fadd-ddb8-4f0a-be9e-58408cbf53c1)
  
## Kullanılan Teknolojiler

Bu projede aşağıdaki teknolojiler ve özellikler kullanılmıştır:

**ASP.NET Core API ve Identity:** RESTful servisler ve kullanıcı yönetimi için ASP.NET Core API ve Identity kullanılmıştır.

**Swagger ve Postman:** API belgeleme ve test için Swagger kullanılırken, Postman ile API test edilmiştir.

**Rapid API ve API Tüketimi:** Dış kaynaklar, Sosyal medya verileri ve hızlı entegrasyonlar için Rapid API kullanılmış, API tüketimi için Postman koleksiyonu sağlanmıştır.

**JSON Web Token (JWT):** Kullanıcı kimlik doğrulama işlemleri için JWT kullanılmıştır.

**ASP.NET Core 7.0 ve MVC:** Proje, ASP.NET Core 7.0 sürümü kullanılarak geliştirilmiş ve MVC tasarım deseni kullanılmıştır.

**Fluent Validation:** Form validasyonları için Fluent Validation kullanılmıştır.

**MSSQL ve Entity Framework Core:** Veritabanı olarak MSSQL kullanılmıştır. Veritabanı işlemleri için Entity Framework Core ve Repository Design Pattern kullanılmıştır.

**Mail Gönderme İşlemleri:** Kullanıcı kaydı veya şifre sıfırlama gibi durumlarda mail gönderme işlemleri için SMTP kullanılmıştır.
  
## Proje Yapısı ve Katmanlı Mimari

Proje, katmanlı mimari prensiplerini takip eder ve şu ana bileşenleri içerir:

**Presentation Layer (Sunum Katmanı):** Kullanıcı arayüzü ile etkileşim sağlanan katmandır. Bu katman, Web API'yi barındırır ve gelen istekleri işler. Ayrıca, projenin kullanıcı arayüzü ile etkileşimde bulunacak olan Web UI (web kullanıcı arayüzü) katmanı eklenmiştir. Bu katman, kullanıcıların projeyi kullanmalarını sağlayacak arayüzleri içerir.

**Business Layer (İş Katmanı):** İş mantığının gerçekleştirildiği katmandır. Bu katman, gelen istekleri işleyerek veritabanı işlemlerini başlatır ve sonuçları sunum katmanına ileterek kullanıcı arayüzünü günceller.

**Data Access Layer (Veri Erişim Katmanı):** Veritabanı işlemlerinin gerçekleştirildiği katmandır. Bu katman, Repository Design Pattern kullanılarak veritabanı ile iletişim kurar.

**Database:** Proje, otel yönetim sistemine ait verileri depolamak için bir veritabanı kullanır. Veritabanı, müşteri bilgileri, oda rezervasyonları, personel takibi gibi temel verileri içerir.

**Web UI (Web Kullanıcı Arayüzü):** Kullanıcıların projeyi kullanmalarını sağlayacak arayüzleri içeren katmandır. Bu katman, kullanıcıların sistemle etkileşimde bulunabilecekleri bir web arayüzü sunar.

  
## Gereksinimler

Bu proje çalıştırılmadan önce aşağıdaki gereksinimlere ihtiyaç duyar:

**.NET Core 7.0 SDK:** Projenin çalıştırılabilmesi için .NET Core 7.0 SDK'nın bilgisayarınıza kurulu olması gerekmektedir. .NET Core SDK İndirme Sayfası

**MSSQL Server:** Veritabanı olarak MSSQL kullanıldığından, MSSQL Server'ın bilgisayarınıza kurulu olması gerekmektedir.

## Ekran Görüntüleri
![3](https://github.com/emreylmz7/HotelApp/assets/65964414/0eb895df-997e-4a71-b457-a27e46b743e7)
![2](https://github.com/emreylmz7/HotelApp/assets/65964414/341b96f6-241a-4a3c-9fce-52210313be2f)
![7](https://github.com/emreylmz7/HotelApp/assets/65964414/70e4b764-574f-47f1-8e2f-5a199e7188d7)
![9](https://github.com/emreylmz7/HotelApp/assets/65964414/309eb5ab-379e-4a99-9319-0352f62ed0f1)
![10](https://github.com/emreylmz7/HotelApp/assets/65964414/11c418b4-8928-40ec-ba6b-6ed00de4aabc)
![12](https://github.com/emreylmz7/HotelApp/assets/65964414/d3c65725-2ae4-4afc-92dc-0b7ed921c8a6)
![13](https://github.com/emreylmz7/HotelApp/assets/65964414/af558149-a30c-4b48-a30b-b0e43b173a2f)
![14](https://github.com/emreylmz7/HotelApp/assets/65964414/d775656a-65dc-43af-8676-a787dcfc50b3)




  

  
