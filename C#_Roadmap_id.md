![Alt text](https://github.com/gridlocdev/csharp-learning-roadmap/raw/main/docs/csharp-roadmap.drawio.svg)
https://github.com/gridlocdev/csharp-learning-roadmap

# Roadmap untuk Belajar Windows Desktop Applications dengan C# dan MS SQL

---

## Daftar Isi
1. [Menyiapkan Lingkungan Pengembangan](#1-menyiapkan-lingkungan-pengembangan)
2. [Pengenalan C# dan Dasar-dasar Pemrograman](#2-pengenalan-c-dan-dasar-dasar-pemrograman)
3. [Struktur Kontrol](#3-struktur-kontrol)
4. [Pemrograman Berorientasi Objek (OOP)](#4-pemrograman-berorientasi-objek-oop)
5. [Aplikasi Windows Forms](#5-aplikasi-windows-forms)
6. [Bekerja dengan MS SQL Server](#6-bekerja-dengan-ms-sql-server)
7. [Kuis dan Ujian Pemrograman](#7-kuis-dan-ujian-pemrograman)
8. [Ujian Akhir](#8-ujian-akhir)

---

## 1. Menyiapkan Software

### **Tujuan**: Pastikan Komputer dan Sofware sudah siap dan berfungsi.

* **1.1 Instal Visual Studio**
  * Pilih beban kerja Pengembangan Desktop C# saat instalasi.
  * Pelajari cara menggunakan Visual Studio untuk membuat dan men-debug proyek.

---

## 2. Pengenalan C# dan Dasar-dasar Pemrograman

### **Tujuan**: Mengajarkan dasar-dasar pemrograman dan mengenalkan konsep dasar C#.

#### **2.1 Pengenalan Pemrograman**
- **Apa itu Pemrograman?**: Penjelasan tentang apa itu menulis program dan bagaimana komputer menjalankan instruksi.
- **Apa itu Compiler?**: Gambaran bagaimana compiler bekerja dan mengapa penting untuk C#.
- **Apa itu IDE (Integrated Development Environment)?**: Pengenalan Visual Studio, cara menulis dan men-debug kode dengan menggunakan IDE ini.

#### **2.2 Sintaks dan Struktur Dasar C#**
- **Variabel dan Tipe Data**: 
  * Pengenalan tipe data umum seperti `int`, `string`, `bool`, dll.
  * Cara mendeklarasikan dan menggunakan variabel di C#.
- **Konstanta dan Enumerasi**: 
  * Memahami konstanta (`const`) dan enumerasi (`enum`).
- **Operator**: 
  * Operator aritmatika, logika, perbandingan, dan penugasan di C#.
- **Struktur Kontrol**: 
  * Pengambilan keputusan: `if`, `switch`.
  * Perulangan: `for`, `while`.

#### **2.3 Fungsi dan Metode**
- **Membuat Fungsi**: Cara membuat fungsi/metode untuk mengorganisir kode.
- **Parameter dan Tipe Kembalian**: Memahami parameter metode, tipe kembalian, dan bagaimana memanggil metode dengan argumen.
- **Overloading Metode**: Membuat metode dengan nama yang sama tapi daftar parameter yang berbeda.

#### **2.4 Penanganan Eksepsi**
- **Try-Catch-Finally**: Pengenalan penanganan eksepsi di C#.
- **Eksepsi Umum**: Menangani eksepsi umum seperti `NullReferenceException`, `FormatException`, dll.

---

## 3. Struktur Kontrol

### **Tujuan**: Menguasai penggunaan struktur kontrol seperti pernyataan `if`, `switch`, dan perulangan di C#.

#### **3.1 Pernyataan If-Else**
- Memahami cara menggunakan `if`, `else`, dan `else if` untuk membuat keputusan dalam kode.

#### **3.2 Pernyataan Switch-Case**
- Belajar kapan harus menggunakan `switch` daripada banyak pernyataan `if`.

#### **3.3 Perulangan**
- **For Loop**: Menggunakan `for` untuk mengulang kode dalam jumlah tertentu.
- **While Loop**: Menggunakan `while` untuk mengulang kode selama kondisi masih benar.

**Contoh Tes:**
- Tulis program untuk memeriksa apakah angka positif, negatif, atau nol.
- Buat kalkulator sederhana menggunakan pernyataan `switch`.
- Cetak tabel perkalian menggunakan perulangan `for`.
- Buat penghitung mundur menggunakan perulangan `while`.

---

## 4. Array dan List

### **Tujuan**: Mengajarkan cara kerja **Array** dan **List** di C# untuk koleksi data.

#### **4.1 Array**
- **Apa itu Array?**: Pengenalan array sebagai koleksi data dengan ukuran tetap.
- **Deklarasi dan Inisialisasi Array**: Cara mendeklarasikan dan menginisialisasi array.
- **Akses Elemen Array**: Mengakses, memperbarui, dan melakukan perulangan pada elemen array.
- **Array Multidimensi**: Pengenalan array 2D dan cara mengakses elemen dalam array berbentuk matriks.

#### **4.2 List**
- **Apa itu List?**: Belajar tentang koleksi data dinamis yang bisa tumbuh atau mengecil ukurannya.
- **Membuat dan Menggunakan List**: Cara mendeklarasikan dan memanipulasi list di C#.
- **Operasi Umum pada List**: Menambah, menghapus, dan mengakses elemen di list.
- **Perulangan Melalui List**: Menggunakan perulangan dan `foreach` untuk iterasi pada list.

#### **4.3 Perbedaan Antara Array dan List**
- Memahami kapan harus menggunakan **array** (ukuran tetap) dibandingkan **list** (ukuran dinamis).
- Membahas perbedaan kinerja, kasus penggunaan, dan manajemen memori.

**Contoh Tes:**
- Buat program yang mengambil input dari pengguna untuk mengisi array angka dan menampilkannya.
- Buat program yang menggunakan list untuk menyimpan nama dan mencetaknya menggunakan perulangan.
- Bangun program yang memanipulasi array dan list dengan mengurutkan, menambah, dan menghapus elemen.

---

## 5. Pemrograman Objek (OOP)

### **Tujuan**: Mengajarkan prinsip dasar OOP menggunakan C#.

#### **5.1 Kelas dan Objek**
- **Apa itu Kelas?**: Pengenalan kelas sebagai cetak biru untuk objek.
- **Membuat Objek**: Cara membuat dan menginstansiasi objek dari kelas.

#### **5.2 Properti dan Metode**
- **Properti**: Cara mendefinisikan dan menggunakan properti untuk merepresentasikan status objek.
- **Metode**: Memahami cara mendefinisikan metode untuk merepresentasikan perilaku objek.

#### **5.3 Pewarisan**
- **Apa itu Pewarisan?**: Belajar bagaimana suatu kelas dapat mewarisi dari kelas lain, mendapatkan properti dan metode darinya.
- **Override Metode**: Memahami cara menimpa metode kelas induk di kelas turunan.

#### **5.4 Polimorfisme**
- **Apa itu Polimorfisme?**: Belajar bagaimana polimorfisme memungkinkan kita menggunakan kelas turunan sebagai pengganti kelas induk, membuat kode lebih fleksibel.

#### **5.5 Enkapsulasi**
- **Apa itu Enkapsulasi?**: Memahami bagaimana menyembunyikan data dalam kelas dan hanya mengeksposnya melalui metode publik (getter dan setter).

**Contoh Tes:**
- Buat kelas `Car` dengan properti seperti `Model`, `Year`, dan `Color`.
- Implementasikan kelas `Dog` dan `Cat` yang menimpa metode `Speak()`.
- Bangun sistem rekening bank sederhana menggunakan pewarisan, dengan `BankAccount` dan `SavingsAccount`.

---

## 6. Aplikasi Windows Forms

### **Tujuan**: Belajar membuat aplikasi desktop menggunakan Windows Forms.

#### **6.1 Pengenalan Aplikasi Windows Forms**
- Belajar cara membuat aplikasi Windows Forms baru di Visual Studio.
- Menambahkan kontrol seperti tombol, label, textbox, dan data grid ke form.

#### **6.2 Penanganan Event**
- Memahami pemrograman berbasis event: menangani event seperti klik tombol, perubahan teks, dll.

#### **6.3 Menghubungkan ke Database dengan ADO.NET**
- Belajar cara menghubungkan aplikasi Windows Forms ke database **SQL Server** menggunakan ADO.NET.
- Melakukan operasi dasar database seperti **Insert**, **Select**, **Update**, dan **Delete**.

**Contoh Tes:**
- Bangun form login yang memvalidasi kredensial pengguna.
- Buat form entri data yang menyimpan data ke database SQL Server dan menampilkannya di `DataGridView`.

---

## 7. MS SQL Server

### **Tujuan**: Belajar cara berinteraksi dengan **MS SQL Server** untuk mengelola data.

#### **7.1 Instalasi SQL Server**
  * Instal **SQL Server Express**.
  * Instal **SQL Server Management Studio (SSMS)** untuk manajemen database.
  * Set up database SQL Server lokal.
  * Pelajari cara membuat database dan tabel menggunakan SQL.

#### **7.2 Membuat Database dan Tabel**
- Menulis query SQL untuk membuat database dan mendefinisikan tabel (misalnya, `Books`, `Users`).

#### **7.3 Melakukan Operasi CRUD**
- Belajar cara melakukan operasi **Create**, **Read**, **Update**, dan **Delete** menggunakan query SQL.
- Berinteraksi dengan database ini dari C# menggunakan **ADO.NET**.

#### **7.4 Query dan Manajemen Data**
- Menggunakan perintah SQL untuk mengambil, memodifikasi, dan menghapus data di SQL Server.

**Contoh Tes:**
- Tulis SQL untuk membuat tabel `Books` dengan kolom seperti `BookID`, `Title`, dan `Author`.
- Gunakan **ADO.NET** di C# untuk menyisipkan record baru ke dalam tabel `Books`.
- Ambil dan tampilkan record dari tabel `Books` di `DataGridView`.

---

## 8. Kuis dan Ujian Pemrograman

Setiap topik dilengkapi dengan kuis dan ujian pemrograman untuk menilai pemahaman dan memperkuat pembelajaran.

### **Kuis**:
- **Dasar-dasar C#**: Uji pemahaman tentang sintaks dasar, variabel, dan struktur kontrol.
- **Konsep OOP**: Uji pemahaman tentang kelas, pewarisan, dan polimorfisme.
- **Windows Forms**: Uji kemampuan membuat form dasar dan menangani event.
- **SQL**: Uji pengetahuan tentang operasi CRUD dan manajemen database.

### **Ujian Pemrograman**:
- **Struktur Kontrol**: Buat program yang menggunakan `if`, `switch`, `for`, dan `while`.
- **OOP**: Bangun aplikasi sederhana menggunakan kelas, objek, dan pewarisan.
- **Windows Forms**: Buat form untuk berinteraksi dengan database.
- **SQL**: Lakukan operasi CRUD pada database menggunakan ADO.NET.

---

## 9. Ujian Akhir

Ujian akhir akan menguji kemampuan siswa untuk membangun **Sistem Manajemen Siswa** menggunakan keterampilan yang telah dipelajari selama kursus.

### **Persyaratan Proyek Akhir**:
- Buat aplikasi Windows Forms yang memungkinkan pengguna untuk:
  - **Menambahkan** siswa ke database.
  - **Melihat** daftar semua siswa.
  - **Memperbarui** detail siswa.
  - **Menghapus** siswa dari database.
  
- Aplikasi ini harus menggunakan **ADO.NET** untuk melakukan operasi database dan menangani input pengguna melalui form.

### **Bonus**:
- Tangani kesalahan dan eksepsi dalam aplikasi (misalnya, input pengguna yang tidak valid, masalah koneksi database).

---

## Kesimpulan

Roadmap ini akan memandu Anda melalui setiap langkah dalam belajar pengembangan perangkat lunak desktop dengan **C#**, **.NET Framework**, dan **MS SQL Server**. Di akhir kursus, Anda akan memiliki keterampilan untuk membuat aplikasi desktop dan berinteraksi dengan database.

---

## Sumber Daya Tambahan
- [Microsoft Docs: C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Microsoft Docs: ADO.NET](https://docs.microsoft.com/en-us/dotnet/framework/data/ado-net/)
- [Tutorial SQL Server](https://www.sqlservertutorial.net/)

---

## Lisensi

Proyek ini dilisensikan di bawah MIT License - lihat file [LICENSE.md](LICENSE.md) untuk detail lebih lanjut.
