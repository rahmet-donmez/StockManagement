
# 📦 Stock Management (Stok Takip Sistemi)

Bu proje, ürünlerin giriş-çıkış hareketlerini takip eden basit bir stok yönetim sistemidir. ASP.NET Core MVC, Entity Framework Core ve MSSQL Server kullanılarak geliştirilmiştir.

## 📋 Özellikler

- Ürün tanımı (Product)
- Stok hareketlerinin kaydı (Inbound / Outbound)
- Ürün bazlı stok ekstresi raporu
- Raporları Excel'e aktarma ve yazdırma
- Entity Framework ile veri erişimi
- Stored Procedure ile hızlı stok hesaplaması

---

## ⚙️ Kurulum Adımları

### 1. Gereksinimler

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) veya VS Code
- Git (isteğe bağlı)



### 2. `appsettings.json` Ayarı

`appsettings.json` dosyasındaki bağlantı cümlesini kendi SQL Server ayarına göre düzenle:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=InventoryDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

> SQL kullanıcı adı/şifre gerekiyorsa:
```json
"DefaultConnection": "Server=localhost;Database=InventoryDb;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
```

---

## 🛠️ Veritabanı İşlemleri

### 1. Migration Oluştur

```bash
dotnet ef migrations add InitialCreate
```

### 2. Veritabanını Oluştur

```bash
dotnet ef database update
```

### 3. Seed Veriler

`OnModelCreating` içerisinde ürün ve hareket verileri otomatik olarak eklenir.

---

## 🧠 Stored Procedure Oluştur

SQL Server Management Studio üzerinden proje içerisinde yer alan prosedürü çalıştır:


## ▶️ Projeyi Çalıştır

```bash
dotnet run
```


## 📤 Özellikler (Kullanıcı Arayüzü)

- Ürün kodu ve tarih aralığı girilerek sorgulama
- Stok ekstresi tablosu görüntüleme

---
