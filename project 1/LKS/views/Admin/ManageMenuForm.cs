using LKS.data_access;
using LKS.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.views.Admin
{
    public partial class ManageMenuForm : Form
    {
        ManageMenuDataAccess da = new ManageMenuDataAccess();

        List<MenuModel> listMenu;
        MenuModel selectedMenu;

        public ManageMenuForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            CLear();

            listMenu = da.GetListMenu();
            Table.DataSource = listMenu;
        }

        void Reload()
        {
            listMenu = da.GetListMenu();
            Table.DataSource = listMenu;
        }

        void CLear()
        {
            selectedMenu = null;

            InputMenuId.Clear();
            InputName.Clear();
            InputPrice.Clear();
            InputPhoto.Clear();
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var menu = listMenu[e.RowIndex];

            selectedMenu = menu;

            InputMenuId.Text = menu.MenuID;
            InputName.Text = menu.Name;
            InputPrice.Text = menu.Price.ToString();
            InputPhoto.Text = menu.Photo;
            Photo.ImageLocation = menu.Photo;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertMenu(new MenuModel
                {
                    Name = InputName.Text,
                    Price = double.Parse(InputPrice.Text),
                    Photo = InputPhoto.Text
                });

                CLear();
                Reload();
            }
            catch (Exception)
            {
                //gagal insert
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateMenu(new MenuModel
                {
                    MenuID = InputMenuId.Text,
                    Name = InputName.Text,
                    Price = double.Parse(InputPrice.Text),
                    Photo = InputPhoto.Text
                });

                Reload();
            }
            catch (Exception ex)
            {
                //gagal update
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                da.DeleteMenu(selectedMenu.MenuID);

                Init();
            }
            catch (Exception)
            {
                //gagal update
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["AdminNavForm"].Show();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            InputPhoto.Text = openFileDialog1.FileName;
            Photo.ImageLocation = openFileDialog1.FileName;
        }
    }
}
