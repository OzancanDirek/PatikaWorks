# Patika.dev Algoritmalar Projeleri

Bu README dosyasında, Patika.dev'deki Veri Yapıları ve Algoritmalar eğitimi kapsamında tamamladığım projeler bulunmaktadır.

## Proje 1: Insertion Sort
Verilen dizi: [22,27,16,2,18,6] -> Insertion Sort

### Soru 1: Yukarıda verilen dizinin sıralama aşamaları

**Insertion Sort Aşamaları:**
[22,27,16,2,18,6]
[16,22,27,2,18,6]
[2,16,22,27,18,6]
[2,16,18,22,27,6]
[2,6,16,18,22,27]

### Soru 2: Dizinin Big-O gösterimi

- **Best Case:** O(n) — Sıralıysa, elemanlar sadece bir kez kontrol edilir.
- **Average Case:** O(n²)
- **Worst Case:** O(n²) — Tersten sıralıysa, her eleman için sıralı kısmın tamamını kontrol etmek gerekir.

### Soru 3: Time Complexity, Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer?

Dizi sıralandıktan sonra 18 sayısı dizinin ortalarına gelmiş oluyor. Bu nedenle **Average Case** uygun olur.

### Soru 4: [7,3,5,8,2,9,4,15,6] dizisinin Selection Sort’a göre ilk 4 adımını yazınız.

**Selection Sort Aşamaları:**
[7, 3, 5, 8, 2, 9, 4, 15, 6]
[2, 3, 5, 8, 7, 9, 4, 15, 6] -> 1. adım
[2, 3, 5, 8, 7, 9, 4, 15, 6] -> 2. adım
[2, 3, 4, 8, 7, 9, 5, 15, 6] -> 3. adım
[2, 3, 4, 5, 7, 9, 8, 15, 6] -> 4. adım

---

## Proje 2: Merge Sort
Verilen dizi: [16,21,11,8,12,22] -> Merge Sort

### Soru 1: Yukarıdaki dizinin sıralama aşamaları

**Merge Sort Aşamaları:**
[16,21,11,8,12,22]
[16,21,11] ____ [8,12,22]
[16,21] [11] ____ [8,12] [22]
[16] [21] [11] ____ [8] [12] [22]
[11,16,21] ____ [8,12,22]
**Merge Sort ile sıralanmış hali:**

### Soru 2: Dizinin Big-O gösterimi

**Merge Sort** her zaman **O(n log n)** zaman karmaşıklığına sahiptir.

---

## Proje 3: Binary Search Tree

Verilen dizi: [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] -> Binary Search Tree

### Soru 1: Yukarıdaki dizisinin Binary Search Tree aşamaları

- **Başlangıçta** 7'yi **root** olarak seçelim.
- Root'un sağında **kendisiyle büyük** olan 8 bulunur, solunda ise **kendisiyle küçük** olan 5 bulunur.

Root'un sağ kısmı:
- 8'in sağında 9 bulunur.

Root'un sol kısmı:
- 5'in sağında 6, solunda ise 1 bulunur.
- 1'in solunda 0, sağında ise 3 bulunur.
- 3'ün sağında 4, solunda ise 2 bulunur.


