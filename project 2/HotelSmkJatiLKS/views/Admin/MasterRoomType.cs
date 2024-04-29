using HotelSmkJatiLKS.dataaccess;
using HotelSmkJatiLKS.models;
using HotelSmkJatiLKS.views.etc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSmkJatiLKS.views.Admin
{
    public partial class MasterRoomType : Form
    {
        RoomTypeDataAccess da = new RoomTypeDataAccess();

        // nyimpen room types dri database
        List<RoomTypeModel> roomtypes;

        // nyimpen room type yg di klik
        RoomTypeModel selectedRoomType;

        public MasterRoomType()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            // variable assingment
            // setting UI
            roomtypes = da.GetRoomTypes();

            LoadTable();

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        public void Reload()
        {

        }

        void LoadTable()
        {
            // bikin list baru, map
            // map ngerubah bentuk list ke bentuk lainnya
            var mapRoomTypes = roomtypes.Select(data => new {
                Name = data.Name,
                Capacity = data.Capacity,
                RoomPrice = data.RoomPrice,
            }).ToList();

            TabelRoomType.DataSource = mapRoomTypes;
        }

        void Clear()
        {
            selectedRoomType = null;

            txtName.Clear();
            inpCapacity.Value = 1;
            txtRoomPrice.Clear();
            openFileDialog1.FileName = "";

            Photo.ImageLocation = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!validasi()) return;


            //masukin data baru ke table bukan database

            roomtypes.Add(new RoomTypeModel { 
                Name = txtName.Text,
                Capacity = int.Parse(inpCapacity.Value.ToString()),
                RoomPrice = double.Parse(txtRoomPrice.Text),
                Photo = Photo.ImageLocation
            });

            Clear();

            LoadTable();
        }

        private void TabelRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //validasi
            if (e.RowIndex == -1) return;

            selectedRoomType = roomtypes[e.RowIndex];

            txtName.Text = selectedRoomType.Name;
            inpCapacity.Value = selectedRoomType.Capacity;
            txtRoomPrice.Text = selectedRoomType.RoomPrice.ToString();

            Photo.ImageLocation = selectedRoomType.Photo;

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            // buka file explorer dan ambil image
            openFileDialog1.ShowDialog();

            Photo.ImageLocation = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validasi()) return;

            var updatedRoomType = new RoomTypeModel
            {
                ID = selectedRoomType.ID,
                Name = txtName.Text,
                Capacity = int.Parse(inpCapacity.Value.ToString()),
                RoomPrice = double.Parse(txtRoomPrice.Text),
                Photo = Photo.ImageLocation
            };

            var indexData = roomtypes.FindIndex(x => x.ID == updatedRoomType.ID);

            roomtypes[indexData] = updatedRoomType;

            LoadTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var doDelete = new Konfirmasi().ShowDialog();

            if (doDelete == DialogResult.Cancel) return;


            var indexData = roomtypes.FindIndex(x => x.ID == selectedRoomType.ID);

            roomtypes.RemoveAt(indexData);

            Clear();

            LoadTable();

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();

            LoadTable();

            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                da.Save(roomtypes);
                Init();
                MessageBox.Show("Data Berhasil Disimpan");
            }
            catch
            {
                MessageBox.Show("Data Gagal Disimpan");
            }
        }

        private void MasterRoomType_FormClosed(object sender, FormClosedEventArgs e)
        {
            new MainFormAdmin().Show();
            
        }

        bool validasi()
        {
            var validasi = new List<string>();

            if(String.IsNullOrEmpty(txtName.Text)) validasi.Add("Room Name tidak boleh kosong");

            try
            {
                double.Parse(inpCapacity.Text);
            }
            catch 
            {
                validasi.Add("Nilai Room Price tidak valid");
            }

            try
            {
                double.Parse(txtRoomPrice.Text);
            }
            catch (Exception)
            {
                validasi.Add("Nilai Room Price tidak valid");
            }           

            if (string.IsNullOrEmpty(Photo.ImageLocation)) validasi.Add("Gambar tidak boleh kosong");

            if (validasi.Count > 0) {
                MessageBox.Show(String.Join("\n", validasi));
                return false;
            } else
            {
                return true;
            }
            

        }
    }
}
