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

namespace HotelSmkJatiLKS.views.FrontDesk
{
    public partial class ReservationForm : Form
    {
        ReservationDataAccess da = new ReservationDataAccess();

        List<CustomerModel> customers = new List<CustomerModel>();
        List<RoomTypeModel> roomTypes = new List<RoomTypeModel>();
        List<RoomModel> rooms = new List<RoomModel>();
        List<RoomModel> selectedRooms = new List<RoomModel>();
        List<ItemModel> items = new List<ItemModel>();
        List<ItemModel> selectedItems = new List<ItemModel>();

        int selectedCustomerIndex = -1;
        int selectedAvailableRoomIndex = -1;
        int selectedListRoomIndex = -1;

        


        public ReservationForm()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            customers = da.GetCustomer();
            roomTypes = da.GetRoomTypes();
            rooms = da.GetRoom(roomTypes.FirstOrDefault().ID);
            items = da.GetItems();

            TableCustomer.DataSource = customers.Select(x => new { 
                Name = x.Name,
                Email = x.Email,
                Gender = x.Gender
            }).ToList();

            InpRoomType.DataSource = roomTypes.Select(x => x.Name).ToList();

            TableAvailableRoom.DataSource = rooms.Select(x => new
            {
                RoomNumber = x.RoomNumber,
                RoomFloor = x.RoomFloor,
                RoomPrice = 10000,
                Description = x.Description
            });

            InpItem.DataSource = items.Select(x => x.Name).ToList();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        void showCustomerSearchMenu()
        {
            RadioAddNew.Checked = false;

            customerAddNewGroup.Visible = false;
            BtnAddNewCustomer.Visible = false;

            labelSearchCustomer.Visible = true;
            InpSearchCustomer.Visible = true;
        }

        void showCustomerAddMenu()
        {
            RadioSearch.Checked = false;

            customerAddNewGroup.Visible = true;
            BtnAddNewCustomer.Visible = true;

            labelSearchCustomer.Visible = false;
            InpSearchCustomer.Visible = false;

        }

        private void RadioSearch_CheckedChanged(object sender, EventArgs e)
        {
            showCustomerSearchMenu();
        }

        private void RadioAddNew_CheckedChanged(object sender, EventArgs e)
        {
            showCustomerAddMenu();
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {

            try
            {
                var newCustomer = new CustomerModel
                {
                    Name = InpCustomerName.Text,
                    NIK = InpCustomerNIK.Text,
                    Email = InpCustomerEmail.Text,
                    Gender = InpCustomerGender.Text,
                    PhoneNumber = InpCustomerPhoneNumber.Text,
                    Age = InpCustomerDateOfBirth.Value.Year - DateTime.Now.Year,
                };

                da.AddCustomer(newCustomer);
                customers.Add(newCustomer);
            }
            catch (Exception) { }
            

            InpCustomerName.Clear();
            InpCustomerNIK.Clear();
            InpCustomerEmail.Clear();
            InpCustomerGender.SelectedIndex = -1;
            InpCustomerPhoneNumber.Clear();

            MessageBox.Show("Berhasil Menambahkan Customer");
        }

        private void InpRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rooms = da.GetRoom(roomTypes[InpRoomType.SelectedIndex].ID);

            TableAvailableRoom.DataSource = rooms.Select(x => new
            {
                RoomNumber = x.RoomNumber,
                RoomFloor = x.RoomFloor,
                RoomPrice = 10000,
                Description = x.Description
            });
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            selectedRooms.Add(rooms[selectedAvailableRoomIndex]);
        }

        private void TableAvailableRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAvailableRoomIndex = e.RowIndex;
        }

        private void TableSelectedRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedListRoomIndex = e.RowIndex;
        }

        private void BtnRemoveRoom_Click(object sender, EventArgs e)
        {
            selectedRooms.RemoveAt(selectedListRoomIndex);
        }

        private void BtnItemAdd_Click(object sender, EventArgs e)
        {
            var item = items[InpItem.SelectedIndex];

            selectedItems.Add(item);

            TableItem.DataSource = selectedItems.Select(x => new
            {
                Item = x.Name,
                Quantity = 2,
                Price = x.RequestPrice,
                SubTotal = x.RequestPrice
            });
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            da.AddReservation(new ReservationModel
            {
                CustomerID = customers[selectedCustomerIndex].ID,
                BookingCode = $"RS{now.Year}{now.Month}{now.Day}{now.Hour}{now.Minute}{now.Second}"
            });

            MessageBox.Show("Berhasil Menambahkan Reservasi");
        }

        private void TableCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCustomerIndex = e.RowIndex;        }
    }
}
