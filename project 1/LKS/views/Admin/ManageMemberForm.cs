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
    public partial class ManageMemberForm : Form
    {
        ManageMemberDataAccess da = new ManageMemberDataAccess();

        MemberModel selectedMember;
        List<MemberModel> members;

        public ManageMemberForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            Clear();

            members = da.GetMembers();
            Table.DataSource = members;
        }

        void Reload()
        {
            members = da.GetMembers();
            Table.DataSource = members;
        }

        void Clear()
        {
            selectedMember = null;

            InputMemberId.Clear();
            InputName.Clear();
            InputEmail.Clear();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["AdminNavForm"].Show();
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            selectedMember = members[e.RowIndex];

            InputMemberId.Text = selectedMember.MemberID;
            InputName.Text = selectedMember.Name;
            InputEmail.Text = selectedMember.Email;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertMember(new MemberModel
                {
                    MemberID = InputMemberId.Text,
                    Name = InputName.Text,
                    Email = InputEmail.Text,

                });

                Clear();
                Reload();
            }
            catch (Exception ex)
            {

                // gagal insert
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateMember(new MemberModel
                {
                    MemberID = InputMemberId.Text,
                    Name = InputName.Text,
                    Email = InputEmail.Text,

                });

                Reload();
            }
            catch (Exception ex)
            {

                // gagal update
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                da.DeleteMember(selectedMember.MemberID);

                Clear();
                Reload();
            }
            catch (Exception)
            {

                // gagal delete
            }
        }
    }
}
