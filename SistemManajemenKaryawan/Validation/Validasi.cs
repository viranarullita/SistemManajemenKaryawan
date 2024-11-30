using System;
using System.Windows.Forms;

namespace SistemManajemenKaryawan.Validation
{
    internal class Validasi
    {
        public bool ValidasiUser(string user)
        {
            for (int a = 0; a < user.Length; a++)
            {
                if (user[a] == ' ' || user[a] == '-' || user[a] == '/' || user[a] == '\\' || user[a] == '?' ||
                    user[a] == '!' || user[a] == '@' || user[a] == '#' || user[a] == '$' || user[a] == '%' ||
                    user[a] == '^' || user[a] == '&' || user[a] == '*' || user[a] == '(' || user[a] == ')' ||
                    user[a] == '`' || user[a] == '~' || user[a] == '+' || user[a] == '=' || user[a] == '[' ||
                    user[a] == ']' || user[a] == '{' || user[a] == '}' || user[a] == ';' || user[a] == '\'' ||
                    user[a] == ':' || user[a] == '\"' || user[a] == ',' || user[a] == '.' || user[a] == '/' ||
                    user[a] == '>' || user[a] == '<' || user[a] == '|')
                {
                    MessageBox.Show("Input Username gagal, perbaiki inputan anda", "Tambah Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (user[0] == ' ' || user[user.Length - 1] == ' ' || user.Length < 5  || user.Length > 12)
            {
                MessageBox.Show("Input Username gagal. Username 5-12 karakter tidak boleh diawali atau diakhiri dengan spasi",
                                "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool ValidasiPassword(string password)
        {
            if (password.Length < 8 || password.Length > 20 || password[0] == ' ' || password[password.Length - 1] == ' ')
            {
                MessageBox.Show("Password gagal. Password harus memiliki panjang antara 8-20 karakter dan tidak boleh diawali atau diakhiri dengan spasi",
                                "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool ValidasiNama(String nama)
        {
            for (int a = 0; a < nama.Length; a++)
            {
                if ((nama[a] >= '0' && nama[a] <= '9') || nama[nama.Length - 1] == ' ' || nama[a] == '-' ||
                    nama[a] == '/' || nama[a] == '\\' || nama[a] == '?' || nama[a] == '!' ||
                    nama[a] == '@' || nama[a] == '#' || nama[a] == '$' || nama[a] == '%' ||
                    nama[a] == '^' || nama[a] == '&' || nama[a] == '*' || nama[a] == '(' ||
                    nama[a] == ')' || nama[a] == '`' || nama[a] == '~' || nama[a] == '+' ||
                    nama[a] == '=' || nama[a] == '[' || nama[a] == ']' || nama[a] == '{' ||
                    nama[a] == '}' || nama[a] == ';' || nama[a] == '\'' || nama[a] == ':' ||
                    nama[a] == '\"' || nama[a] == ',' || nama[a] == '.' || nama[a] == '/' ||
                    nama[a] == '>' || nama[a] == '<' || nama[a] == '|')
                {
                    MessageBox.Show("Input nama gagal, perbaiki inputan anda", "Tambah nama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool ValidasiNohp(string telp)
        {
            for (int a = 0; a < telp.Length; a++)
            {
                if ((telp[a] >= 'A' && telp[a] <= 'Z') || (telp[a] >= 'a' && telp[a] <= 'z') ||
                    telp[a] == ' ' || telp[a] == '-' || telp[a] == '/' || telp[a] == '\\' || telp[a] == '?' ||
                    telp[a] == '!' || telp[a] == '@' || telp[a] == '#' || telp[a] == '$' || telp[a] == '%' ||
                    telp[a] == '^' || telp[a] == '&' || telp[a] == '*' || telp[a] == '(' || telp[a] == ')' ||
                    telp[a] == '`' || telp[a] == '~' || telp[a] == '+' || telp[a] == '=' || telp[a] == '[' ||
                    telp[a] == ']' || telp[a] == '{' || telp[a] == '}' || telp[a] == ';' || telp[a] == '\'' ||
                    telp[a] == ':' || telp[a] == '\"' || telp[a] == ',' || telp[a] == '.' || telp[a] == '/' ||
                    telp[a] == '>' || telp[a] == '<' || telp[a] == '|')
                {
                    MessageBox.Show("Input No Hp gagal, perbaiki inputan anda", "Tambah No Hp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (telp.Length < 2 || telp[0] != '0' || telp[1] != '8')
            {
                MessageBox.Show("Nomor HP harus diawali dengan '08'.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (telp.Length < 10 || telp.Length > 13)
            {
                MessageBox.Show("Nomor telepon harus memiliki minimal 10 digit - 13 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool ValidasiPosisi(string posisi)
        {
            for (int a = 0; a < posisi.Length; a++)
            {
                if ((posisi[a] >= '0' && posisi[a] <= '9') || posisi[posisi.Length - 1] == ' ' || posisi[a] == '-' ||
                    posisi[a] == '/' || posisi[a] == '\\' || posisi[a] == '?' || posisi[a] == '!' ||
                    posisi[a] == '@' || posisi[a] == '#' || posisi[a] == '$' || posisi[a] == '%' ||
                    posisi[a] == '^' || posisi[a] == '&' || posisi[a] == '*' || posisi[a] == '(' ||
                    posisi[a] == ')' || posisi[a] == '`' || posisi[a] == '~' || posisi[a] == '+' ||
                    posisi[a] == '=' || posisi[a] == '[' || posisi[a] == ']' || posisi[a] == '{' ||
                    posisi[a] == '}' || posisi[a] == ';' || posisi[a] == '\'' || posisi[a] == ':' ||
                    posisi[a] == '\"' || posisi[a] == ',' || posisi[a] == '.' || posisi[a] == '/' ||
                    posisi[a] == '>' || posisi[a] == '<' || posisi[a] == '|')
                {
                    MessageBox.Show("Input nama departemen gagal, perbaiki inputan anda", "Tambah nama departemen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool ValidasiNamaDept(string namaDept)
        {
            for (int a = 0; a < namaDept.Length; a++)
            {
                if ((namaDept[a] >= '0' && namaDept[a] <= '9') || namaDept[namaDept.Length - 1] == ' ' || namaDept[a] == '-' ||
                    namaDept[a] == '/' || namaDept[a] == '\\' || namaDept[a] == '?' || namaDept[a] == '!' ||
                    namaDept[a] == '@' || namaDept[a] == '#' || namaDept[a] == '$' || namaDept[a] == '%' ||
                    namaDept[a] == '^' || namaDept[a] == '&' || namaDept[a] == '*' || namaDept[a] == '(' ||
                    namaDept[a] == ')' || namaDept[a] == '`' || namaDept[a] == '~' || namaDept[a] == '+' ||
                    namaDept[a] == '=' || namaDept[a] == '[' || namaDept[a] == ']' || namaDept[a] == '{' ||
                    namaDept[a] == '}' || namaDept[a] == ';' || namaDept[a] == '\'' || namaDept[a] == ':' ||
                    namaDept[a] == '\"' || namaDept[a] == ',' || namaDept[a] == '.' || namaDept[a] == '/' ||
                    namaDept[a] == '>' || namaDept[a] == '<' || namaDept[a] == '|')
                {
                    MessageBox.Show("Input namaDept gagal, perbaiki inputan anda", "Tambah namaDept", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool ValidasiGaji(string gaji)
        {
            for (int a = 0; a < gaji.Length; a++)
            {
                if ((gaji[a] >= 'A' && gaji[a] <= 'Z') || (gaji[a] >= 'a' && gaji[a] <= 'z') ||
                    gaji[a] == ' ' || gaji[a] == '-' || gaji[a] == '/' || gaji[a] == '\\' || gaji[a] == '?' ||
                    gaji[a] == '!' || gaji[a] == '@' || gaji[a] == '#' || gaji[a] == '$' || gaji[a] == '%' ||
                    gaji[a] == '^' || gaji[a] == '&' || gaji[a] == '*' || gaji[a] == '(' || gaji[a] == ')' ||
                    gaji[a] == '`' || gaji[a] == '~' || gaji[a] == '+' || gaji[a] == '=' || gaji[a] == '[' ||
                    gaji[a] == ']' || gaji[a] == '{' || gaji[a] == '}' || gaji[a] == ';' || gaji[a] == '\'' ||
                    gaji[a] == ':' || gaji[a] == '\"' || gaji[a] == ',' || gaji[a] == '.' || gaji[a] == '/' ||
                    gaji[a] == '>' || gaji[a] == '<' || gaji[a] == '|')
                {
                    MessageBox.Show("Input Gaji gagal, perbaiki inputan anda", "Tambah Gaji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (int.TryParse(gaji, out int nilaiGaji))
            {
                if (nilaiGaji < 50000)
                {
                    MessageBox.Show("Gaji harus minimal 50.000.", "Tambah Gaji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Input gaji tidak valid.", "Tambah Gaji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
