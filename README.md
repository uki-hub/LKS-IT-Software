# IF Statement

```
if (kondisi) {
  // Kode didalam blok ini akan dijalankan bila kondisi nya benar
} else {
  // Kode didalam blok ini akan dijalankan bila kondisi nya salah
}
```

## Contoh

```
if(tahunSekarang >= 2024) {
  if(tahunSekarang == 2024) {
    Console.WriteLine("Tahun sekarang adalah 2024");
  } else {
    Console.WriteLine("Tahun sekarang lebih dari 2024");
  }
} else {
  Console.WriteLine("Tahun sekarang dibawah dari 2024");
}
```

<br />

# Switch Statement

<pre>
switch (variabel) {
    case <b>nilai1</b>:
        // kode yang dijalankan jika variabel == <b>nilai1</b>
        break;
    case <b>nilai2</b>:
        // kode yang dijalankan jika variabel == <b>nilai2</b>
        break;
    default:
        // kode yang dijalankan jika variabel tidak cocok dengan semua kasus
        break;
</pre>

<br />

# List, Array
Array adalah kumpulan elemen yang memiliki tipe data sama, diakses dengan menggunakan indeks(nomor posisi letak data di List/Array.)

List adalah kumpulan data yg sama, <b>yang jumlah nya dapat berubah ukuran.</b>


```
int[] angka = new int[5]; // Array dari 5 integer

List<int> angkaList = new List<int>(); // List untuk menyimpan integer
```

## Contoh
```
int[] angkaArray = { 1, 2, 3, 4, 5 };

List<string> buahList = new List<string> { "Apel", "Mangga", "Pisang" };
```

<br />

# For Loop Statement
For loop digunakan untuk menjalankan blok kode secara <b>berulang-ulang</b> sampai <b>kondisi tertentu terpenuhi.</b>
<pre>
for (int i = 0; <b>i < 5</b>; i++) {
    // Blok kode yang dijalankan secara berulang ulang. Sampai dengan kondisi (<b>i < 5</b>). atau variabel i tidak lebih kecil lagi dari angka 5
}
</pre>

## contoh
```
for (int i = 0; i < 5; i++) {
    Console.WriteLine("Nilai i sekarang: " + i);
}

List<string> daftarBuah = new List<string> { "Apel", "Mangga", "Pisang" };

for (int i = 0; i < daftarBuah.length; i++) {
    string buah = daftarBuah[i];  //ambil data dari variabel list daftarBuah mengunakan index    

    Console.WriteLine("Buah " + buah + " urutan ke " + (i + 1).ToString());
}
```

<br />

# Method, Function, Parameter
Method atau Function adalah blok kode yang melakukan tugas tertentu dan dapat dipanggil dengan nama tersebut. Dalam C#, biasanya disebut sebagai method.

Parameter adalah variabel yang digunakan untuk menerima data dari luar pada saat sebuah method dipanggil.

```
void MyMethod(string parameter) {
    // Blok kode
}
```

## contoh
```
public void SapaPengguna(string nama) {
    Console.WriteLine("Halo, " + nama);
}

SapaPengguna("Andi"); // Memanggil method dengan mengirimkan "Andi" sebagai parameter
```

<br />

# Prinsip OOP
Prinsip OOP meliputi konsep seperti <b>Encapsulation, Inheritance, Polymorphism, dan Abstraction </b> yang memungkinkan pemrograman yang lebih modular, fleksibel, dan mudah untuk di-maintain

<br/>

# Classes
Class adalah blueprint dari objek yang mendefinisikan variabel (properties) dan metode (methods) yang dimiliki oleh objek tersebut.

```
public class Hewan {
    public string Nama { get; set; }
    public void Berbicara() {
        Console.WriteLine(Nama + " mengatakan halo!");
    }
}
```

<br />

# New Keyword
new digunakan untuk membuat instansi (instance) dari sebuah class atau struktur data lainnya.
```
Mobil mobilku = new Mobil(); // Membuat objek baru dari class Mobil

Hewan kucing = new Hewan();
kucing.Nama = "Kitty";
kucing.Berbicara();
```

<br />

---
# Optional

<br />

## Encapsulation, Inheritance, Polymorphism, dan Abstraction
- <b>Encapsulation (Enkapsulasi) </b> <br/>
  Encapsulation adalah teknik menyembunyikan detail internal suatu objek dan hanya mengekspos operasi yang aman kepada dunia luar. Ini seperti menjaga informasi sensitif agar tidak sembarangan diakses

  <b>Contoh: </b><br/>
  Dalam sebuah sistem manajemen akun pengguna, detail seperti saldo atau password pengguna disimpan sebagai variabel privat dalam kelas UserAccount

  <b>Use Case: </b><br />
  Encapsulation memastikan bahwa saldo hanya dapat diubah melalui metode deposit atau withdraw yang aman, mencegah perubahan langsung yang mungkin menyebabkan inkonsistensi data

- <b>Inheritance  (Pewarisan) </b> <br />
  Inheritance memungkinkan suatu kelas mewarisi sifat dan metode dari kelas lain. Ini seperti anak yang mewarisi karakteristik atau harta dari orang tuanya

  <b>Contoh: </b><br/>
  Anda memiliki kelas Vehicle yang memiliki properti umum seperti speed dan metode accelerate. Kelas Car dan Bicycle mewarisi dari Vehicle dan menambahkan properti spesifik mereka sendiri, seperti engineSize untuk Car

  <b>Use Case: </b><br />
  Inheritance memungkinkan Car dan Bicycle menggunakan properti dan metode dari Vehicle tanpa harus mendefinisikannya ulang, memudahkan pengembangan dan maintain

- <b>Polymorphism (Polimorfisme)</b> <br />
  Polymorphism adalah konsep yang memungkinkan kita untuk melakukan tugas yang sama dengan cara yang berbeda. Ini berarti bahwa suatu metode dapat memiliki banyak bentuk. Dalam konteks OOP, polimorfisme memungkinkan kita untuk mendefinisikan metode dalam kelas induk dan kemudian mengubahnya di kelas anak

  <b>Contoh: </b><br/>
  Dalam aplikasi pengolah dokumen, Anda mungkin memiliki kelas Shape dengan metode draw. Kelas Circle, Square, dan Triangle mewarisi dari Shape dan masing-masing mengimplementasikan draw dengan cara yang unik

  <b>Use Case: </b><br />
  Polymorphism memungkinkan Anda untuk memanggil metode draw pada array of Shape, dan setiap objek akan menampilkan bentuknya sendiri, memungkinkan kode yang fleksibel dan mudah untuk diperluas

- <b>Abstraction (Abstraksi) </b> <br />
  Abstraction adalah proses menyembunyikan detail implementasi dan menampilkan hanya fungsionalitas kepada pengguna. Ini memungkinkan kita untuk fokus pada apa yang dilakukan objek daripada bagaimana itu dilakukan.

  <b>Contoh: </b><br/>
  Dalam sistem perbankan, Anda mungkin memiliki interface PaymentGateway dengan metode processPayment. Kelas-kelas seperti CreditCardPayment dan PaypalPayment mengimplementasikan PaymentGateway, masing-masing dengan cara yang spesifik untuk prosesor pembayaran tersebut
 
  <b>Use Case: </b><br />
  Abstraction memungkinkan sistem untuk mendukung berbagai metode pembayaran, sambil menyembunyikan detail kompleks dari setiap proses pembayaran dari kode yang mengkonsumsi interface PaymentGateway. Ini memfasilitasi perluasan dengan metode pembayaran baru tanpa mengubah sistem yang ada

<br />

## Generic Type
Generic type memungkinkan class, interface, dan method untuk bekerja dengan berbagai tipe data tanpa perlu melakukan konversi tipe data.

```
public class GenericList<T> {
    void Add(T input) { }
}
```

## contoh 
```
public class Kotak<T> {
    private T isi;
    public void SetIsi(T isiBaru) {
        this.isi = isiBaru;
    }
    public T GetIsi() {
        return this.isi;
    }
}

Kotak<string> kotakString = new Kotak<string>();
kotakString.SetIsi("Hello World");
Console.WriteLine(kotakString.GetIsi());
```





