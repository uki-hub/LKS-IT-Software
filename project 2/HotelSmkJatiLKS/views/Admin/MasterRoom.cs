using HotelSmkJatiLKS.dataaccess;
using HotelSmkJatiLKS.models;
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
    public partial class MasterRoom : Form
    {
        RoomDataAccess da = new RoomDataAccess();
        RoomModel selectedRoom;
        List<RoomModel> rooms; 
        List<RoomTypeModel> roomTypes; 

        public MasterRoom()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            Clear();

            rooms = da.GetRooms();
            roomTypes = da.GetRoomTypes();

            var mapRoomTypes = roomTypes.Select(x => x.Name).ToList();

            Tabel.DataSource = rooms;
            txtRoomType.DataSource = mapRoomTypes;
        }

        void Reload()
        {
            Clear();

            Tabel.DataSource = rooms;
        }

        void Clear()
        {
            selectedRoom = null;

            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex = -1;
            txtRoomFloor.Clear();
            txtDescription.Clear();
        }

        private void Tabel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var room = rooms[e.RowIndex];

            selectedRoom = room;

            txtRoomNumber.Text = room.RoomNumber;
            txtRoomType.SelectedIndex = room.GetRoomTypeIndex();
            txtRoomFloor.Text = room.RoomFloor;
            txtDescription.Text = room.Description;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void MasterRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            new MainFormAdmin().Show();
        }
    }
}
