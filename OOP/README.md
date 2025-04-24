# OOP (Object-Oriented Programming)

Bu repo, Patika.dev adresinde yer alan Object-Oriented Programming eğitimindeki ödevleri içermektedir.

## Uçuş Yönetim Sistemi

Bu repo, uçuşların ve pilotların yönetimi için tasarlanmış bir sistemin kodlarını içermektedir. Sistem, aşağıdaki bileşenleri ve ilişkileri kapsayacak şekilde tasarlanmıştır.

- **Hava yolu şirketleri uçuşları gerçekleştirir.**
- Her hava yolunun bir kimliği vardır.
- **Hava yolu şirketi, farklı tipteki uçaklara sahiptir.**
- **Uçaklar çalışır veya onarım durumunda olabilir.**
- **Her uçuşun benzersiz kimliği, kalkacağı ve ineceği havaalanı, kalkış ve iniş saatleri vardır.**
- **Her uçuşun bir pilotu ve yardımcı pilotu vardır ve uçağı kullanırlar.**
- **Havaalanlarının benzersiz kimlikleri ve isimleri vardır.**
- **Hava yolu şirketlerinin pilotları vardır ve her pilotun bir deneyim seviyesi mevcuttur.**
- **Bir uçak tipi, belirli sayıda pilota ihtiyaç duyabilir.**

---

## Hayvanat Bahçesi Yönetim Sistemi

Bu repo, bir hayvanat bahçesindeki hayvanlar hakkındaki bilgileri takip etmek için tasarlanmış bir yönetim sisteminin kodlarını içermektedir. Sistem, farklı hayvan gruplarını (Atlar, Kedigiller, Kemirgenler vb.) yönetmek ve her grup için farklı işlevleri yerine getirmek amacıyla polimorfizm modelini kullanmaktadır.

- **Hayvanlar**: (Atlar, zebralar, eşekler vb.)
- **Kedigiller**: (Kaplanlar, aslanlar vb.)
- **Kemirgenler**: (Sıçanlar, kunduzlar vb.)

Her grup, hayvanlar hakkında depolanan bazı ortak bilgilere (tür adı, ağırlığı, yaşı vb.) sahiptir. Ancak, her gruba özgü işlevler farklılık göstermektedir.

---

## Film Satın Alma & Kiralama Sistemi

Bu repo, çevrimiçi film kiralama ve satın alma uygulamasının sistem tasarımını içermektedir. Kullanıcılar, filmleri listeleyebilir, sıralayabilir ve abonelik alarak kredilerle film kiralayabilirler. Sistemde abonelik, kredi yönetimi ve film talep etme gibi işlevler bulunmaktadır.

- Uygulama, mevcut filmleri listeleyebilir ve kullanıcıların filmleri sıralamalarına olanak tanır.
- Kullanıcılar, uygulamaya abone olabilir. Abonelik için kullanıcılar kredi satın alırlar.
- Sadece abone olan kullanıcılar, aldıkları kredilerle film kiralayabilir.
- Kiralanan film için kredi bedeli kullanıcı hesabından düşülür.
- Hem normal kullanıcılar hem de aboneler film satın alabilirler.
- Eğer bir film mevcut değilse, kullanıcılar bu filmi talep edebilirler.

---

## Gelişmiş Asansör Sistemi

Bu repo, 12 katlı bir ofis binasında kullanılacak gelişmiş bir asansör sisteminin simülasyonunu içermektedir. Sistem, binadaki asansörlerin işlemlerini ve yolcu akışını modellemek için tasarlanmıştır. Aşağıdaki bileşenler ve ilişkiler sisteme dahil edilmiştir:

- **Bina içindeki 12 katlı ofis binasında 5 asansör bulunmaktadır.**
- **Her asansörün altı yetişkin yolcu kapasitesi vardır.**
- **Asansörler enerji tasarruflu olacak şekilde tasarlanmış ve yalnızca gerektiğinde hareket ederler.**
- **Her asansörün kendi kapısı, kat gösterge ışığı ve kontrol paneli vardır.**
- **Kontrol panelinde hedef düğmeleri, kapı açma ve kapama düğmeleri ve bir acil durum sinyal düğmesi bulunmaktadır.**
- **Binada her kat için 5 asansör boşluğuna karşılık bir kapı ve her kapının üzerinde varış zili bulunmaktadır.**
- **Varış zili, asansörün bir kata vardığını gösterir.**
- **Her katta 3 set asansör çağrı düğmesi bulunmaktadır.**
- **Yolcular, uygun çağrı düğmesine basarak asansör çağırabilirler.**
- **Bir programlayıcı, aramanın başladığı kata gitmek için bir asansör görevlendirir.**
- **Asansöre binen yolcular, bir veya daha fazla hedef düğmesine basarak gitmek istedikleri katları seçerler.**
- **Asansör, yolculuk sırasında bir gösterge ışığı ile yolcuları asansörün konumu hakkında bilgilendirir.**
- **Bir asansör bir katta durduğunda, kapılar otomatik olarak açılır ve yolcuların asansöre binip inmesini sağlar.**
- **Simülatör, gerçek zaman geçişini simüle etmek için bir "saat" kullanır ve zaman damgası ile olayları kaydeder.**
- **Simülasyonda rastgele bir sayı üreteci kullanılarak yolcular oluşturulur ve her yolcu için kalkış ve varış katları belirlenir.**

## 🎓 Üniversite Yönetim Sistemi

Bu repo, bir üniversitenin yapısını modelleyen bir sistemin simülasyonunu içermektedir. Sistem, üniversite içindeki departmanlar, ofisler, çalışanlar ve sınıflar gibi bileşenleri kapsayacak şekilde tasarlanmıştır.

- Üniversiteye ait sınıflar, çalışma ofisleri ve departmanlar bulunmaktadır.
- Her departman bir veya daha fazla ofise sahiptir.
- Üniversite bünyesinde çalışan kişiler profesör veya memur olabilir.
- Her çalışan belirli bir ofiste görev yapar.
- Çalışanlar aynı zamanda belirli bir departmana bağlıdır.
- Sınıflar, derslerin işlendiği fiziksel alanları temsil eder.
- Ofisler, çalışan personelin görev yaptığı alanlardır.

