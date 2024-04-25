using LKS.data_access;
using LKS.models;
using LKS.store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views.Chef
{
    public partial class OrderForm : Form
    {
        OrderDataAccess da = new OrderDataAccess();

        List<MenuModel> listMenu;
        List<OrderModel> listOrder;

        MenuModel selectedMenu;
        OrderModel selectedOrder;

        public OrderForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            listMenu = da.GetListMenu();
            listOrder = new List<OrderModel>();


            var menu = listMenu.Select(x => new { Menu = x.Name, Price = x.Price }).ToList();
            TableMenu.DataSource = menu;
        }

        void Clear()
        {
            InputMenuName.Clear();
            InputQty.Clear();
            InputPrice.Clear();
            Photo.ImageLocation = "";

            selectedMenu = null;
        }

        void Reload()
        {

        }


        void ReloadOrderTable()
        {
            TableOrder.Columns.Clear();

            var order = listOrder.Select(x => new { Menu = x.Menu.Name, x.Qty, x.Menu.Price, Total = x.Menu.Price * x.Qty }).ToList();

            if(order.Count <= 0) return;

            LabelTotal.Text = order.Select(x => x.Total).Sum().ToString();

            TableOrder.DataSource = order;
        }

        private void TableMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var menu = listMenu[e.RowIndex];

            InputMenuName.Text = menu.Name;
            InputQty.Text = "1";
            InputPrice.Text = $"Total : {menu.Price.ToString()}";
            Photo.ImageLocation = menu.Photo;

            selectedMenu = menu;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (selectedMenu == null) return;

            listOrder.Add(new OrderModel
            {
                Menu = selectedMenu,
                Qty = int.Parse(InputQty.Text),
            });

            ReloadOrderTable();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            da.Order(MainStore.user.EmployeeID, "", listOrder);

            listOrder.Clear();


            ReloadOrderTable();
        }

        private void TableOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedOrder = listOrder[e.RowIndex];
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var orderIndex = listOrder.FindIndex((x) => x.Menu.MenuID == selectedOrder.Menu.MenuID);

            listOrder.RemoveAt(orderIndex);

            ReloadOrderTable();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["CashierNavForm"].Show();
        }
    }
}
