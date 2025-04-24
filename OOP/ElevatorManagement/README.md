# Gelişmiş Asansör Sistemi

Bu repo, 12 katlı bir ofis binasında beş asansörün simülasyonunu gerçekleştiren bir yazılımı içermektedir. Sistem, asansörlerin hareketini, yolcu etkileşimlerini ve bina içindeki trafik akışını modellemektedir. Nesne Yönelimli Programlama ilkeleri (Encapsulation, Inheritance, Polymorphism, Abstraction) kullanılarak tasarlanmıştır.

## Proje Özeti

- **Asansörler**:
  - Binada 5 asansör bulunur, her biri 12 kat arasında hareket edebilir.
  - Her asansör 6 yetişkin yolcu kapasitesine sahiptir.
  - Asansörlerde kapı, kat göstergesi ve kontrol paneli vardır.

- **Kontrol Paneli ve İşlevsellik**:
  - Hedef düğmeleri, kapı açma/kapama düğmesi ve acil durum sinyal düğmesi bulunur.
  - Her katta, asansör çağırmak için yukarı ve aşağı düğmeleri mevcuttur.

- **Kat Zili ve Sinyal Işığı**:
  - Her katta varış zili ve sinyal ışığı bulunur, asansörün varışını ve hareket yönünü gösterir.

- **Yolcu Etkileşimi**:
  - Yolcular, çağrı düğmelerine basarak asansör çağırır ve hedef katlarına gitmek için düğmelere basar.
  - Asansör, yolcuları istediği katlara taşıyarak varışlarda kapıları otomatik açar.

- **Simülasyon Saat ve Günlük Kaydı**:
  - Gerçek zamanlı geçiş simülasyonu yapılır, olaylar zaman damgası ve günlük kaydıyla takip edilir.
  - Rastgele bir yolcu oluşturulur ve kalkış ile varış katları belirlenir.
