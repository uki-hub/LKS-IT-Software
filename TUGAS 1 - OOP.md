### Soal Pemrograman C# OOP dengan Tema Manusia

Anda ditugaskan untuk membuat sebuah program sederhana menggunakan prinsip Object-Oriented Programming (OOP) di C# yang mengelola informasi tentang beberapa orang dalam suatu komunitas atau lingkungan kerja. Program ini harus mencakup penggunaan konsep-konsep dasar pemrograman seperti `if`, `for` loop, `switch`, `List`, metode, fungsi, parameter, serta penggunaan kata kunci `public` dan `private`.

#### Deskripsi Soal

1. **Kelas `Manusia`**:
   - **Atribut (Properties)**:
     - `nama` (string): Nama dari orang tersebut, hanya dapat diakses dan dimodifikasi melalui metode publik.
     - `umur` (int): Umur orang tersebut, hanya dapat diakses dan dimodifikasi melalui metode publik.
     - `pekerjaan` (string): Pekerjaan orang tersebut, hanya dapat diakses dan dimodifikasi melalui metode publik.

   - **Metode**:
     - Konstruktor yang menerima parameter untuk setiap atribut dan menginisialisasi atribut tersebut.
     - `TampilkanInfo()`: Sebuah metode publik yang mencetak informasi tentang orang tersebut.
     - Getter dan Setter untuk setiap atribut, dengan validasi di setter (misal, umur tidak boleh negatif).

2. **Kelas `Komunitas`**:
   - **Atribut**:
     - `anggota` (List<Manusia>): Sebuah list yang menyimpan objek-objek `Manusia`.

   - **Metode**:
     - `TambahAnggota(Manusia m)`: Menambahkan objek `Manusia` ke dalam `anggota`.
     - `TampilkanAnggota()`: Menampilkan informasi dari semua anggota.
     - `CariAnggotaBerdasarkanPekerjaan(string pekerjaan)`: Menampilkan informasi anggota berdasarkan pekerjaan tertentu.
     - `HitungAnggotaBerdasarkanUmur(int batasBawah, int batasAtas)`: Menghitung dan menampilkan jumlah anggota yang umurnya berada dalam rentang tertentu.

3. **Logika Tambahan**:
   - Dalam `CariAnggotaBerdasarkanPekerjaan`, gunakan `switch` untuk menangani beberapa pekerjaan spesifik, dan default untuk pekerjaan lainnya.
   - Dalam `HitungAnggotaBerdasarkanUmur`, gunakan `for` loop dan `if` untuk menghitung anggota dalam rentang umur tertentu.
   - Implementasikan logika validasi dalam setter atribut `Manusia`, misalnya, untuk memastikan umur tidak negatif.

#### Tugas

1. Implementasikan kedua kelas `Manusia` dan `Komunitas` dengan semua atribut, metode, dan logika seperti yang dijelaskan.
2. Dalam method `main`, buatlah instance dari kelas `Komunitas` dan tambahkan beberapa `Manusia` ke dalamnya dengan berbagai nama, umur, dan pekerjaan.
3. Gunakan metode `TampilkanAnggota` untuk menampilkan semua anggota komunitas.
4. Gunakan metode `CariAnggotaBerdasarkanPekerjaan` untuk mencari anggota dengan pekerjaan "Pengajar" dan tampilkan hasilnya.
5. Gunakan metode `HitungAnggotaBerdasarkanUmur` untuk menghitung anggota yang berumur antara 20 hingga 30 tahun dan tampilkan hasilnya.

#### Catatan

- Pastikan untuk mempraktikkan penggunaan `public` dan `private` secara tepat untuk mendemonstrasikan pemahaman Anda tentang enkapsulasi dalam OOP.
- Ingatlah untuk menulis kode yang bersih dan mudah dibaca, dengan memanfaatkan komentar untuk menjelaskan logika yang rumit jika perlu.
- Validasi input pengguna di setter untuk menghindari pengaturan nilai yang tidak valid pada atribut.
