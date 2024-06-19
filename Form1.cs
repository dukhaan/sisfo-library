using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISFOPerpustakaanMockup
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }
            private bool isDragging = false;
            private int mouseX, mouseY;

            private void pnlTop_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

    
    

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = true;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            //tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = true;
            pnlLaporan.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = true;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            //tampilkan panel konten
            pnlDataMaster.Visible = false;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = true;
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            //button dipilih
            lblSelected1.Visible = true; 
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;

            //tampilkan panel konten
            pnlDataMaster.Visible = true;
            pnlTransaksi.Visible = false;
            pnlLaporan.Visible = false;
        }

        private void btnLainnya_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = true;
            lblSelected5.Visible = false;
            lblSelected6.Visible = false;
        }

        private void btnTentang_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = true;
            lblSelected6.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = false;
            lblSelected5.Visible = false;
            lblSelected6.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'perpustakaanDataSet.grafik' table. You can move, or remove it, as needed.
            this.grafikTableAdapter.Fill(this.perpustakaanDataSet.grafik);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.denda' table. You can move, or remove it, as needed.
            this.dendaTableAdapter.Fill(this.perpustakaanDataSet.denda);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.pengembalianbuku' table. You can move, or remove it, as needed.
            this.pengembalianbukuTableAdapter.Fill(this.perpustakaanDataSet.pengembalianbuku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.peminjamanbuku' table. You can move, or remove it, as needed.
            this.peminjamanbukuTableAdapter.Fill(this.perpustakaanDataSet.peminjamanbuku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.laporandatamaster' table. You can move, or remove it, as needed.
            this.laporandatamasterTableAdapter.Fill(this.perpustakaanDataSet.laporandatamaster);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.perpustakaanDataSet.buku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.kategoribuku' table. You can move, or remove it, as needed.
            this.kategoribukuTableAdapter.Fill(this.perpustakaanDataSet.kategoribuku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.rakbuku' table. You can move, or remove it, as needed.
            this.rakbukuTableAdapter.Fill(this.perpustakaanDataSet.rakbuku);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.pustakawan' table. You can move, or remove it, as needed.
            this.pustakawanTableAdapter.Fill(this.perpustakaanDataSet.pustakawan);
            // TODO: This line of code loads data into the 'perpustakaanDataSet.anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.perpustakaanDataSet.anggota);

        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            subAnggota.Visible = true;
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan perubahan hanya dilakukan pada kolom yang diinginkan (misalnya kolom "Nama")
            if (e.ColumnIndex == dataGridView1.Columns["Nama"].Index)
            {
                // Dapatkan nilai yang diubah
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Lakukan validasi dan pengolahan data lain yang diperlukan sebelum menyimpan ke database

                // Dapatkan ID unik dari baris yang diubah (misalnya kolom "ID" pada kolom tersembunyi)
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                // Buat koneksi ke database
                string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    try
                    {
                        // Buka koneksi ke database
                        connection.Open();

                        // Buat perintah SQL UPDATE dengan parameter
                        string queryUpdate = "UPDATE NamaTabel SET Nama = ? WHERE ID = ?";
                        using (OdbcCommand commandUpdate = new OdbcCommand(queryUpdate, connection))
                        {
                            commandUpdate.Parameters.AddWithValue("Nama", newValue);
                            commandUpdate.Parameters.AddWithValue("ID", id);

                            // Jalankan perintah UPDATE
                            int rowsAffected = commandUpdate.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil diperbarui di database.");
                            }
                            else
                            {
                                MessageBox.Show("Gagal memperbarui data di database.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["del"].Index && e.RowIndex >= 0)
            {
                int anggotaID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
                string deleteQuery = "DELETE FROM anggota WHERE ID = ?";

                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    connection.Open();

                    using (OdbcCommand deleteCommand = new OdbcCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("ID", anggotaID);
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Baris berhasil dihapus dari database
                            // Lakukan tindakan lain jika diperlukan
                        }
                        else
                        {
                            // Tidak ada baris yang dihapus dari database
                        }
                    }
                }

                // Hapus baris yang terpilih dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;
                string namaAnggota = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();

                // Ambil sel yang sesuai dari kolom DataGridViewTextBoxColumn
                DataGridViewCell namaCell = dataGridView1.Rows[selectedRowIndex].Cells[1];

                // Periksa tipe sel dan set nilai teks
                if (namaCell is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell textBoxCell = (DataGridViewTextBoxCell)namaCell;
                    textBoxCell.Value = namaAnggota;
                }

                btnSimpan.Tag = selectedRowIndex;
                Edit.Visible = true;
            }

            if (e.ColumnIndex == dataGridView1.Columns["update"].Index && e.RowIndex >= 0)
    {
        int selectedRowIndex = e.RowIndex;
        int anggotaID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
        
        // Dapatkan nilai dari sel-sel yang akan diperbarui
        string namaAnggota = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
        string alamatAnggota = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
        string teleponAnggota = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();

        // Buat koneksi ke database
        string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
        using (OdbcConnection connection = new OdbcConnection(connectionString))
        {
            try
            {
                // Buka koneksi ke database
                connection.Open();

                // Buat perintah SQL UPDATE dengan parameter
                string updateQuery = "UPDATE anggota SET Nama = ?, Alamat = ?, Telepon = ? WHERE ID = ?";
                using (OdbcCommand updateCommand = new OdbcCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("Nama", namaAnggota);
                    updateCommand.Parameters.AddWithValue("Alamat", alamatAnggota);
                    updateCommand.Parameters.AddWithValue("Telepon", teleponAnggota);
                    updateCommand.Parameters.AddWithValue("ID", anggotaID);

                    // Jalankan perintah UPDATE
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Data berhasil diperbarui
                        MessageBox.Show("Data anggota berhasil diperbarui.");
                                refreshOrder();
                    }
                    else
                    {
                        // Gagal memperbarui data
                        MessageBox.Show("Gagal memperbarui data anggota.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

        }

        private void refreshOrder()
        {
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            string query = "SELECT * FROM anggota ORDER BY id ASC";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Membaca data dari database
                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Assign DataTable sebagai sumber data DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Penanganan kesalahan
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            pnlTambahAnggota.Visible = true;
            subAnggota.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txtIdAnggota.Text;
            string nama = txtNamaAnggota.Text;
            string alamat = txtAlamatAnggota.Text;
            string telepon = txtTeleponAnggota.Text;

            // Validasi input kosong
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(alamat) || string.IsNullOrEmpty(telepon))
            {
                MessageBox.Show("Mohon lengkapi semua field.");
                return;
            }

            // Membuat koneksi ke database
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    // Membuka koneksi ke database
                    connection.Open();

                    // Mengecek apakah ID anggota sudah ada di database
                    string queryCheckId = "SELECT COUNT(*) FROM Anggota WHERE ID = ?";
                    using (OdbcCommand commandCheckId = new OdbcCommand(queryCheckId, connection))
                    {
                        commandCheckId.Parameters.AddWithValue("ID", id);

                        int count = Convert.ToInt32(commandCheckId.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("ID anggota sudah ada.");
                            return;
                        }
                    }

                    // Menambahkan anggota ke database
                    string queryInsertAnggota = "INSERT INTO anggota (ID, Nama, Alamat, Telepon) VALUES (?, ?, ?, ?)";
                    using (OdbcCommand commandInsertAnggota = new OdbcCommand(queryInsertAnggota, connection))
                    {
                        commandInsertAnggota.Parameters.AddWithValue("ID", id);
                        commandInsertAnggota.Parameters.AddWithValue("Nama", nama);
                        commandInsertAnggota.Parameters.AddWithValue("Alamat", alamat);
                        commandInsertAnggota.Parameters.AddWithValue("Telepon", telepon);

                        int rowsAffected = commandInsertAnggota.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Anggota berhasil ditambahkan.");
                            // Lakukan tindakan lain setelah anggota ditambahkan, jika diperlukan.
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan anggota.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void RefreshSubAnggota()
        {
            // Lakukan operasi refresh data di panel subAnggota di sini
            // Misalnya, mengambil data anggota dari database dan menampilkan dalam DataGridView

            // Contoh penggunaan DataGridView untuk menampilkan data anggota
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            string query = "SELECT * FROM anggota";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Mengatur sumber data DataGridView ke DataTable
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlTambahAnggota.Visible = false;
            subAnggota.Visible = true;
            RefreshSubAnggota();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            pnlSubPustakawan.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlSubPustakawan.Visible = true;
        }

        private void btnRak_Click(object sender, EventArgs e)
        {
            pnlSubRakBuku.Visible = true;
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            pnlSubRakBuku.Visible = false;

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            pnlSubKategori.Visible = true;
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            pnlSubBuku.Visible = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pnlSubBuku.Visible=false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pnlSubKategori.Visible=false;
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            pnlSubLaporan.Visible=false;
        }

        private void btnLapMaster_Click(object sender, EventArgs e)
        {
            pnlSubLaporan.Visible = true;
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            pnlSubPeminjaman.Visible=true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pnlSubPeminjaman.Visible = false; 
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            pnlSubPengembalian.Visible=true;
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            pnlSubPengembalian.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlSubPeminjamanLaporan.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pnlSubDenda.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pnlSubDenda.Visible=false;
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            pnlSubPeminjamanLaporan.Visible=false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlSubGrafik.Visible=true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pnlSubGrafik.Visible = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            
        }

        private void subAnggota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            //pnlTambahLaporan.Visible = true;
        }

        private void pnlTambahBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIdAnggota_Click(object sender, EventArgs e)
        {

        }

        private void pnlTambahAnggota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdAnggota_TextChanged(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            string id = txtIdBuku.Text;
            string judul = txtJudulBuku.Text;
            string penulis = txtPenulis.Text;
            string tahunterbit = txtTahunTerbit.Text;

            // Validasi input kosong
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(penulis) || string.IsNullOrEmpty(tahunterbit))
            {
                MessageBox.Show("Mohon lengkapi semua field.");
                return;
            }

            // Membuat koneksi ke database
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    // Membuka koneksi ke database
                    connection.Open();

                    // Mengecek apakah ID anggota sudah ada di database
                    string queryCheckId = "SELECT COUNT(*) FROM buku WHERE ID = ?";
                    using (OdbcCommand commandCheckId = new OdbcCommand(queryCheckId, connection))
                    {
                        commandCheckId.Parameters.AddWithValue("ID", id);

                        int count = Convert.ToInt32(commandCheckId.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("ID buku sudah ada.");
                            return;
                        }
                    }

                    // Menambahkan anggota ke database
                    string queryInsertAnggota = "INSERT INTO buku (id, judul, penulis, tahunterbit) VALUES (?, ?, ?, ?)";
                    using (OdbcCommand commandInsertAnggota = new OdbcCommand(queryInsertAnggota, connection))
                    {
                        commandInsertAnggota.Parameters.AddWithValue("ID", id);
                        commandInsertAnggota.Parameters.AddWithValue("Nama", judul);
                        commandInsertAnggota.Parameters.AddWithValue("Alamat", penulis);
                        commandInsertAnggota.Parameters.AddWithValue("Telepon", tahunterbit);

                        int rowsAffected = commandInsertAnggota.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Anggota berhasil ditambahkan.");
                            // Lakukan tindakan lain setelah anggota ditambahkan, jika diperlukan.
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan anggota.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshSubBuku()
        {
            // Lakukan operasi refresh data di panel subAnggota di sini
            // Misalnya, mengambil data buku dari database dan menampilkannya dalam DataGridView

            // Contoh penggunaan DataGridView untuk menampilkan data buku
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            string query = "SELECT * FROM buku";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Mengatur sumber data DataGridView ke DataTable
                        dataGridView5.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }


        private void button38_Click(object sender, EventArgs e)
        {
            pnlTambahBuku.Visible = false;
            pnlSubBuku.Visible = true;
            RefreshSubBuku();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pnlTambahBuku.Visible = true;
            pnlSubBuku.Visible = false;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.ColumnIndex == dataGridView5.Columns["delBuku"].Index && e.RowIndex >= 0)
                {
                    int bukuID = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells[0].Value);

                    string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
                    string deleteQuery = "DELETE FROM buku WHERE ID = ?";

                    using (OdbcConnection connection = new OdbcConnection(connectionString))
                    {
                        connection.Open();

                        using (OdbcCommand deleteCommand = new OdbcCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("ID", bukuID);
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Baris berhasil dihapus dari database
                                // Lakukan tindakan lain jika diperlukan
                            }
                            else
                            {
                                // Tidak ada baris yang dihapus dari database
                            }
                        }
                    }

                    // Hapus baris yang terpilih dari DataGridView
                    dataGridView5.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void pnlTambahPeminjaman_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }
        private void RefreshSubPeminjaman()
        {
            // Lakukan operasi refresh data di panel subAnggota di sini
            // Misalnya, mengambil data buku dari database dan menampilkannya dalam DataGridView

            // Contoh penggunaan DataGridView untuk menampilkan data buku
            string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
            string query = "SELECT * FROM peminjamanbuku";
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Mengatur sumber data DataGridView ke DataTable
                        dataGridView7.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            pnlTambahPeminjaman.Visible = false;
            pnlSubPeminjaman.Visible = true;
            RefreshSubPeminjaman();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            {
                string id = txtIdPeminjaman.Text;
                string idBuku = txtIdBukuP.Text;
                string idAnggota = txtIdAnggotaP.Text;
                string idPustakawan = txtIdPustakawanP.Text;
                string tglPeminjaman = txtTanggalPeminjaman.Text;
                string tglKembali = txtTanggalKembali.Text;
                

                // Validasi input kosong
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(idBuku) || string.IsNullOrEmpty(idAnggota) || string.IsNullOrEmpty(idPustakawan) ||  string.IsNullOrEmpty(tglPeminjaman) || string.IsNullOrEmpty(tglKembali))
                {
                    MessageBox.Show("Mohon lengkapi semua field.");
                    return;
                }

                // Membuat koneksi ke database
                string connectionString = "DSN=Perpustakaan;Uid=postgres;Pwd=123;";
                using (OdbcConnection connection = new OdbcConnection(connectionString))
                {
                    try
                    {
                        // Membuka koneksi ke database
                        connection.Open();

                        // Mengecek apakah ID anggota sudah ada di database
                        string queryCheckId = "SELECT COUNT(*) FROM peminjamanbuku WHERE ID = ?";
                        using (OdbcCommand commandCheckId = new OdbcCommand(queryCheckId, connection))
                        {
                            commandCheckId.Parameters.AddWithValue("ID", id);

                            int count = Convert.ToInt32(commandCheckId.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("ID Peminjaman sudah ada.");
                                return;
                            }
                        }

                        // Menambahkan anggota ke database
                        string queryInsertAnggota = "INSERT INTO peminjamanbuku (id, id_buku, id_anggota, id_pustakawan, tanggalpeminjaman, tanggalpengembalian) VALUES (?, ?, ?, ?, ?, ?)";
                        using (OdbcCommand commandInsertAnggota = new OdbcCommand(queryInsertAnggota, connection))
                        {
                            commandInsertAnggota.Parameters.AddWithValue("id", id);
                            commandInsertAnggota.Parameters.AddWithValue("id_buku", idBuku);
                            commandInsertAnggota.Parameters.AddWithValue("id_anggota", idAnggota);
                            commandInsertAnggota.Parameters.AddWithValue("id_pustakawan", idPustakawan);
                            commandInsertAnggota.Parameters.AddWithValue("tanggalpeminjaman", tglPeminjaman);
                            commandInsertAnggota.Parameters.AddWithValue("tanggalpengembalian", tglKembali);

                            int rowsAffected = commandInsertAnggota.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Anggota berhasil ditambahkan.");
                                // Lakukan tindakan lain setelah anggota ditambahkan, jika diperlukan.
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambahkan anggota.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            pnlTambahPeminjaman.Visible = true;
            pnlSubPeminjaman.Visible = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Tag != null)
            {
                // Get the row index to be edited from the tag of the Save button
                int rowIndex = Convert.ToInt32(btnSimpan.Tag);

                // Get the modified value from the TextBox or relevant control
                string newValue = Edit.Text;

                // Perform validation and other data processing if needed

                // Get the unique ID from the row to be edited (e.g., from a hidden "ID" column)
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);

                // Establish a database connection and perform the UPDATE operation as before
                // ...
            }
        }

        private void btnKembaliList_Click(object sender, EventArgs e)
        {
            subAnggota.Visible = false;
        }

        
    }
}
