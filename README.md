# 🥐 BAKER - Corporate Website & Admin Dashboard

Bu proje, ASP.NET Core teknolojileri kullanılarak **Onion Architecture** prensiplerine uygun şekilde geliştirilmiş dinamik bir kurumsal web sitesi ve içerik yönetim (Yönetici Paneli) sistemidir. Sistem, Backend (Web API) ve Frontend (MVC) olmak üzere iki ana modülden oluşmaktadır.

## 🚀 Proje Mimarisi ve Yapısı

Proje, servis tabanlı bir mimari ile inşa edilmiştir:
* **QuickStartWebApi:** Veritabanı işlemleri, iş mantığı ve dış dünyaya veri sunumunu gerçekleştiren RESTful API katmanı.
* **QuickStartWebUI:** Kullanıcı arayüzü ve Yönetici Panelini barındıran, API ile `IHttpClientFactory` üzerinden haberleşen ASP.NET Core MVC katmanı.

## 🌟 Öne Çıkan Özellikler

- **Dinamik İçerik Yönetimi:** Slider, Hizmetler, Ürünler, Galeri, Ekip ve Referanslar gibi bölümlerin tamamı admin panelinden yönetilebilir.
- **Gelişmiş Gelen Kutusu (İletişim):** Kullanıcıların web sitesi üzerinden gönderdiği mesajlar API üzerinden veritabanına kaydedilir ve admin panelinde anlık okunmamış mesaj bildirimi (Badge) ile listelenir.
- **Modern Arayüz:** Kullanıcı tarafında mobil uyumlu modern bir tasarım, yönetici tarafında ise Breeze Admin Template kullanılarak şık ve kullanışlı bir dashboard sunulmuştur.
- **Güvenli API Tüketimi:** Arayüz (UI) katmanı veritabanına doğrudan bağlanmaz; tüm CRUD işlemleri JSON formatında Web API üzerinden gerçekleştirilir.

## 💻 Kullanılan Teknolojiler

- **Backend:** C#, ASP.NET Core Web API, Entity Framework Core
- **Frontend / UI:** ASP.NET Core MVC, HTML5, CSS3, Bootstrap
- **Mimari:** Onion Architecture
- **Veri İletişimi:** IHttpClientFactory, Newtonsoft.Json (DTO tabanlı veri transferi)

## 📸 Ekran Görüntüleri
<img width="1897" height="1016" alt="1" src="https://github.com/user-attachments/assets/196b12fc-ea18-4585-bc33-f956d573f1e8" />
<img width="1896" height="1013" alt="2" src="https://github.com/user-attachments/assets/ed945bdc-a17a-4103-b940-8ee99740bfd7" />
<img width="1895" height="1015" alt="3" src="https://github.com/user-attachments/assets/0cdbf3a5-9442-4b42-bbaa-618c1dea0a13" />
<img width="1897" height="1015" alt="4" src="https://github.com/user-attachments/assets/c2063fc6-3d92-4fea-ade7-3e597691b627" />
<img width="1895" height="1015" alt="5" src="https://github.com/user-attachments/assets/98ba83a9-67c3-4b7a-a05a-4e8d50285b76" />
<img width="1893" height="1013" alt="6" src="https://github.com/user-attachments/assets/2a49147b-3729-4084-b2b0-bb16c2b0bf18" />
<img width="1897" height="1012" alt="7" src="https://github.com/user-attachments/assets/c61a0064-8205-46eb-ae7d-23bb48e6784f" />
<img width="1897" height="1012" alt="8" src="https://github.com/user-attachments/assets/1654622c-370d-43f0-87a5-5feac3826ee6" />
<img width="1897" height="1015" alt="9" src="https://github.com/user-attachments/assets/22d3d0c6-e9f0-45c0-97fc-c5c3a7e5fe2c" />
<img width="1896" height="1012" alt="10" src="https://github.com/user-attachments/assets/0a6141d7-8296-45a3-ac53-be81daf23541" />
<img width="1898" height="1017" alt="11" src="https://github.com/user-attachments/assets/49196340-e137-4bbb-a5a1-4af93b76e91c" />
<img width="1898" height="1016" alt="12" src="https://github.com/user-attachments/assets/07843284-6bfa-406f-bf76-c2bbf6fd4f2a" />
<img width="1897" height="1012" alt="13" src="https://github.com/user-attachments/assets/d757b86e-d4ad-4b3d-bb3d-662d14923efa" />
<img width="1897" height="1013" alt="14" src="https://github.com/user-attachments/assets/b3dce167-3aaf-4559-b932-c355f3706f92" />
<img width="1897" height="1012" alt="15" src="https://github.com/user-attachments/assets/98650415-e51a-4b6f-8315-868eea70db0d" />
<img width="1896" height="1016" alt="16" src="https://github.com/user-attachments/assets/e56f0d3d-fb30-43a3-9c8c-5310dc6f566a" />
<img width="1897" height="1013" alt="17" src="https://github.com/user-attachments/assets/842bcd64-4d8b-4254-92e4-85535f70ca41" />
<img width="1895" height="1015" alt="18" src="https://github.com/user-attachments/assets/fc65b3ee-5690-4877-8c71-3996e78593a8" />

## ⚙️ Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/yasindenizcure/QuickStart.git](https://github.com/yasindenizcure/QuickStart.git)
