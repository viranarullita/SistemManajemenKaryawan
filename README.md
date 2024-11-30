# Sistem Manajemen Karyawan

Proyek ini adalah aplikasi *Sistem Manajemen Karyawan* berbasis Windows Forms, dikembangkan dengan C# menggunakan arsitektur MVC (Model-View-Controller). Aplikasi ini dirancang untuk mengelola data karyawan, departemen, gaji, dan fitur login pengguna.

## Fitur Utama

- *Manajemen Karyawan*: Tambah, lihat, ubah, dan hapus data karyawan.
- *Manajemen Departemen*: Mengelola informasi departemen.
- *Manajemen Gaji*: Hitung dan simpan data gaji karyawan.
- *Autentikasi Pengguna*: Fitur login dan pendaftaran pengguna.
- *Dashboard*: Antarmuka pengguna untuk menampilkan data secara keseluruhan.

## Struktur Proyek

- *Controller/*: Berisi logika aplikasi, termasuk:
  - KaryawanController.cs
  - DepartemenController.cs
  - GajiController.cs
  - LoginController.cs
- *Model/*: Mengatur koneksi database, seperti:
  - Connection.cs
- *View/*: Antarmuka pengguna (UI) berbasis Windows Forms, contoh:
  - FormDashboard.cs
  - FormKaryawan.cs
  - FormSignIn.cs
- *Properties/*: Konfigurasi aplikasi.
- *App.config*: Konfigurasi aplikasi untuk koneksi dan pengaturan lainnya.

## Cara Menjalankan Proyek

1. Pastikan Anda memiliki *Visual Studio* (disarankan versi terbaru) dan *.NET Framework 4.7.2* atau lebih baru.
2. Clone atau unduh proyek ini.
3. Buka file solusi (SistemManajemenKaryawan.sln) di Visual Studio.
4. Konfigurasikan database di App.config sesuai kebutuhan.
5. Build dan jalankan aplikasi.

## Diagram
![ERD]()

## Teknologi yang Digunakan

- *Bahasa Pemrograman*: C#
- *Framework*: .NET Framework
- *Desain Arsitektur*: MVC (Model-View-Controller)

## Kontribusi

Jika Anda ingin berkontribusi pada proyek ini, silakan lakukan fork, buat branch baru untuk perubahan Anda, dan kirim pull request.

Dikembangkan oleh: *Vira Narullita*
