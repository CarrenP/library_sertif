# Library Management System

## Deskripsi Proyek
Library Management System adalah aplikasi desktop berbasis Windows Forms yang dibangun dengan C# untuk mengelola sistem perpustakaan. Aplikasi ini menyediakan fitur untuk manajemen buku, peminjaman, dan pengelolaan anggota perpustakaan.

##  Fitur Utama

### Admin:
- **Manajemen Buku**: Tambah, hapus, dan lihat daftar buku di perpustakaan
- **Monitor Peminjaman**: Melihat seluruh daftar peminjaman dengan status (dipinjam/dikembalikan/terlambat)
- **Overdue**: Status overdue ditandai dengan warna merah dan bold

### User/Member
- **Browse Katalog Buku**: Melihat daftar buku yang tersedia dengan informasi stok
- **Pinjam Buku**: Meminjam buku dengan double-click pada daftar
- **Kelola Peminjaman**: Melihat riwayat peminjaman dan mengembalikan buku
- **Return System**: Tombol return untuk buku yang telah selesai dipinjam

### Fitur Umum
- **Auto-generate Member ID**: Member ID otomatis dengan format MEM0001, MEM0002, dst
- **Session Management**: Sistem login dengan role-based access (Admin/User)
- **Loan Tracking**: Pencatatan peminjaman ke file log
- **Due Date System**: Periode peminjaman 7 hari dengan perhitungan otomatis
- **Overdue Alert**: Notifikasi visual untuk buku yang terlambat dikembalikan

## Teknologi yang Digunakan

- **Framework**: .NET Framework 4.8
- **Language**: C# 
- **UI Framework**: Windows Forms
- **Database**: MySQL (library_db)
- **Package Manager**: NuGet
- **MySQL Connector**: MySql.Data 9.5.0

## Database Schema

### Tabel: users
CREATE TABLE users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    member_id VARCHAR(20) UNIQUE,
    name VARCHAR(100),
    address TEXT,
    email VARCHAR(100),
    sex ENUM('Male', 'Female'),
    age INT,
    password VARCHAR(255),
    role ENUM('ADMIN', 'USER') DEFAULT 'USER'
);

### Tabel: books
CREATE TABLE books (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(200),
    author VARCHAR(100),
    stock INT DEFAULT 0
);


### Tabel: loans
CREATE TABLE loans (
    id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT,
    book_id INT,
    loan_date DATE,
    due_date DATE,
    is_returned TINYINT(1) DEFAULT 0,
    returned_date DATE,
    FOREIGN KEY (user_id) REFERENCES users(id),
    FOREIGN KEY (book_id) REFERENCES books(id)
);


## 👥 Default Admin Account
Untuk login sebagai admin, tambahkan data berikut ke database:

INSERT INTO users (member_id, name, address, email, sex, age, password, role) 
VALUES ('ADMIN001', 'Administrator', 'Admin Address', 'admin@library.com', 'Male', 30, 'admin123', 'ADMIN');

**Login Credentials:**
- Member ID: `ADMIN001`
- Password: `admin123`

## Struktur Aplikasi
library-system/
├── Forms/
│   ├── home.cs                    # Halaman utama
│   ├── LoginForm.cs               # Form login
│   ├── signup.cs                  # Form registrasi
│   ├── AdminMenuForm.cs           # Menu admin
│   ├── UserMenuForm.cs            # Menu user
│   ├── bookmanagement.cs          # Kelola buku (admin)
│   ├── bookborrowed.cs            # Daftar peminjaman (admin)
│   ├── booklist.cs                # Katalog buku (user)
│   └── loanlist.cs                # Peminjaman user
├── Models/
│   ├── User.cs                    # Model user
│   ├── Book.cs                    # Model buku
│   └── Loan.cs                    # Model peminjaman
├── Data/
│   ├── Database.cs                # Koneksi database
│   └── Session.cs                 # Session management
├── Program.cs                     # Entry point
└── packages.config                # NuGet dependencies

## Cara Penggunaan

### Untuk Member Baru
1. Klik **MEMBER SIGN UP** di halaman utama
2. Isi form registrasi (Name, Address, Email, Age, Gender, Password)
3. Klik **Be a Member!**
4. Catat Member ID yang ditampilkan (contoh: MEM0001)
5. Login menggunakan Member ID dan password

### Untuk Admin
1. Login dengan kredensial admin
2. Dashboard menampilkan semua buku
3. Klik **Book Management** untuk mengelola buku
4. Klik **BORROW LIST** untuk melihat semua peminjaman

### Untuk User
1. Login dengan Member ID dan password
2. Klik **Book List** untuk melihat katalog
3. Double-click buku untuk meminjam
4. Klik **Borrow Books** untuk melihat peminjaman
5. Klik tombol **Return** untuk mengembalikan buku

##  Catatan

- Password disimpan dalam plaintext (untuk development). Untuk production, gunakan hashing (BCrypt/SHA256)
- Default loan period: 7 hari
- Stock buku otomatis berkurang saat dipinjam dan bertambah saat dikembalikan
- Loan history tersimpan di file `loan_log.txt`

## Future Improvements

- [ ] Password hashing untuk keamanan
- [ ] Sistem denda untuk keterlambatan
- [ ] Export laporan ke PDF/Excel
- [ ] Email notification untuk due date
- [ ] Search dan filter buku
- [ ] Multi-branch support
- [ ] Dashboard analytics

## 👨‍💻 Author

Developed by Carren
