CREATE DATABASE manajemenkaryawan;
USE manajemenkaryawan;

CREATE TABLE admin (
    username VARCHAR(50) NOT NULL,
    pasword VARCHAR(50) NOT NULL
);

CREATE TABLE departemen (
    id_dept INT AUTO_INCREMENT PRIMARY KEY,
    nama_dept VARCHAR(50) NOT NULL
);

CREATE OR REPLACE TABLE karyawan (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(50) NOT NULL,
    jenis_kelamin ENUM('Laki-laki', 'Perempuan') NOT NULL,
    no_hp VARCHAR(15) NOT NULL,
    posisi VARCHAR(50) NOT NULL,
    id_dept INT,
    tanggal_bergabung DATE NOT NULL,
    statuss ENUM('Aktif', 'Nonaktif') NOT NULL,
    FOREIGN KEY (id_dept) REFERENCES departemen(id_dept) ON DELETE SET NULL
);

CREATE TABLE gaji (
    id_gaji INT AUTO_INCREMENT PRIMARY KEY,
    id_karyawan INT NOT NULL,
    gaji INT NOT NULL,
    statuss ENUM('Diterima', 'Belum') DEFAULT 'Belum',
    tanggal_penerimaan DATE DEFAULT NULL,
    FOREIGN KEY (id_karyawan) REFERENCES karyawan(id) ON DELETE CASCADE
);

INSERT INTO admin (username, pasword) VALUES 
('admin1', 'password123'),
('admin2', 'password456');

INSERT INTO departemen (nama_dept) VALUES 
('HRD'),
('Customer Service'),
('Finance');

INSERT INTO karyawan (nama, jenis_kelamin, no_hp, posisi, id_dept, tanggal_bergabung, statuss) VALUES 
('Indah', 'Perempuan', '0817429846', 'Manager', 1, '2020-05-10', 'Aktif'),
('Ucup', 'Laki-laki', '08123456790', 'Staff', 2, '2022-08-15', 'Aktif'),
('Widia', 'Perempuan', '08123456791', 'Supervisor', 3, '2021-06-20', 'Nonaktif'),
('Upin', 'Laki-laki', '08128726794', 'Staff', 3, '2024-11-10', 'Aktif');

INSERT INTO gaji (id_karyawan, gaji, statuss, tanggal_penerimaan) VALUES 
(1, 5000000, 'Diterima', '2024-11-01'),
(2, 3000000, 'Belum', '2024-11-10'),
(3, 4500000, 'Diterima', '2024-11-10'),
(4, 7000000, 'Diterima', '2024-11-25');