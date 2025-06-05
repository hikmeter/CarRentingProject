# 🚗 UdemyCarBook

`UdemyCarBook`, C# dili ve .NET Core 8.0 teknolojisi ile geliştirilmiş, katmanlı ve ölçeklenebilir bir **araç kiralama/rezervasyon API** projesidir. Proje, **Murat Yücedağ**’ın Udemy üzerindeki yazılım geliştirme eğitimi temel alınarak oluşturulmuştur.

Bu projede yazılım geliştirme ilkelerine uygun olarak **Onion (Soğan) mimarisi**, **CQRS**, **Mediator**, **DTO**, ve **Entity Framework Core** gibi modern mimari ve teknolojiler kullanılmıştır.

> 🎯 Temiz, sürdürülebilir ve test edilebilir bir mimari ile araç kiralama API'si oluşturulmuştur.

---

## 🧱 Proje Mimarisi

Projede aşağıdaki yapı benimsenmiştir:

- **Onion Architecture (Katmanlı yapı)**: 
  - Domain
  - Application
  - Infrastructure
  - Persistence
  - WebAPI

- **CQRS (Command Query Responsibility Segregation)**: Okuma ve yazma işlemleri ayrıştırılmıştır.
- **Mediator Pattern (MediatR)**: Katmanlar arası gevşek bağlılık sağlanmıştır.
- **DTO (Data Transfer Object)**: Verilerin transferinde sade ve güvenli yapı kullanılmıştır.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| **.NET Core 8.0** | Ana geliştirme platformu |
| **C#** | Yazılım dili |
| **Entity Framework Core** | ORM |
| **MSSQL Server** | Veritabanı |
| **MediatR** | CQRS ve mediator pattern uygulaması |
| **Swagger** | API test ve dökümantasyon aracı |
| **AutoMapper** | Nesne eşleme işlemleri |
| **FluentValidation** | Veri doğrulama işlemleri |

---

## 🚗 Temel Özellikler

- 📌 Araç listesi ve detay görüntüleme
- 📝 Araç kiralama ve rezervasyon işlemleri (CRUD)
- 🧱 Katmanlı yapı ile modüler geliştirme
- ⚙️ CQRS desenine uygun Command ve Query ayrımı
- 🔄 DTO ile veri transfer güvenliği ve sadeliği
- 🔍 Swagger UI ile API test desteği

---

## 📁 Katmanlar ve Sorumluluklar

- `CarBook.Domain` → Temel varlıklar ve iş kuralları
- `CarBook.Application` → CQRS, DTO'lar, handler’lar
- `CarBook.Infrastructure` → DI, servis konfigürasyonları
- `CarBook.Persistence` → EF Core ile veritabanı işlemleri
- `CarBook.WebAPI` → API uç noktaları (Controllers)

---

## 💾 Veritabanı

- Proje, MSSQL Server kullanarak veri saklar.
- Migration işlemleri için `Package Manager Console` kullanılabilir

