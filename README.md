# Localizer Projesi

ASP.NET Core ile hazırlanan Localizer projesi, bir web uygulamasını kolayca çok dilli hale getirmek için tasarlanmıştır. Kullanıcılar, navbardaki dil menüsünü kullanarak Türkçe ve İngilizce arasında geçiş yapabilir. Proje, modern bir tasarımla desteklenmiş ve kullanıcı dostu bir arayüze sahiptir.

## 📋 Özellikler

- 🌐 **Çoklu Dil Desteği**: Türkçe ve İngilizce dilleri arasında geçiş yapma.
- 📊 **Grafikler**: Satış verilerini göstermek için Chart.js kullanımı.
- 🎨 **Modern Arayüz**: Bootstrap ile responsive tasarım.
- 🔄 **Dinamik Dil Değiştirme**: Dil tercihi çerezlerle kaydedilir ve kullanıcı dil seçimini korur.

---

## 🛠️ Kullanılan Teknolojiler

### Backend
- **ASP.NET Core MVC**: Uygulamanın temel çatısı.
- **Localization**: ASP.NET Core'un yerelleştirme desteği.
- **Dependency Injection**: Bağımlılıkların daha düzenli yönetimi.
- **Logging**: Hata yönetimi ve izleme.

### Frontend
- **Bootstrap**: Kullanıcı dostu, responsive bir arayüz.
- **CSS/SCSS**: Özel tasarım ve stil düzenlemeleri.
- **Chart.js**: Satış verilerinin görselleştirilmesi.

### Diğer
- **Git**: Projenin sürüm kontrolü.
- **Flag-Icon CSS**: Dil seçiminde bayrak ikonları kullanımı.

---

## 🖼️ Ekran Görüntüleri

### Ana Sayfa (Türkçe)
![image](https://github.com/user-attachments/assets/47fa918d-7a3a-4ec5-8921-159c74db0cd0)
![image](https://github.com/user-attachments/assets/25cb83f4-03c3-4c39-a94b-2e4b9625e050)

### Ana Sayfa (İngilizce)
![image](https://github.com/user-attachments/assets/808e9fa9-6d31-4c63-ac97-4f536c84bad4)
![image](https://github.com/user-attachments/assets/82e4d4a3-9e6b-48ed-b828-85f13f9f23ea)

### Hakkımızda (Türkçe)
![image](https://github.com/user-attachments/assets/82d154d4-0681-45f6-b2a0-7e3a78faf5d0)

### Hakkımızda (İngilizce)
![image](https://github.com/user-attachments/assets/eb6a16f5-dc5b-4d35-b623-53969bcc0df3)

---

## 🚀 Kurulum

Projenin çalıştırılması için aşağıdaki adımları izleyin:

### Gereksinimler
- .NET 7.0 SDK veya daha güncel bir sürüm
- Visual Studio ya da Visual Studio Code

### Adımlar

1. **Projeyi Klonlayın**
   git clone https://github.com/OguzcanErtul/Localizer.git

## 🛠️ Proje Yapısı

### 📂 **Controllers**
- **`HomeController`**: Ana sayfa, gizlilik ve dil değiştirme işlemleri.

### 📂 **Views**
- **`Index.cshtml`**: Ana sayfa.
- **`Privacy.cshtml`**: Gizlilik sayfası.
- **`About.cshtml`**: Hakkımızda sayfası.

### 📂 **Resources**
- Çoklu dil desteği için çeviri dosyalarını içerir.

### 📂 **Static Files**
- **CSS**: Özel stilleri içerir.
- **JavaScript**: Dinamik içerik ve etkileşim için gerekli dosyalar.
- **Medya**: Görseller, ikonlar gibi statik dosyaları içerir.

---

## 🌍 Dil Değiştirme
Dil değişimi, navbardaki dil seçim menüsü ile yapılabilir. Seçim çerezlere kaydedildiği için sonraki ziyaretlerde de aynı dil kullanılır.
