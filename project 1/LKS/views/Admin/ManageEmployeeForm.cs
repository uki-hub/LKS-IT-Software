using LKS.data_access;
using LKS.lib;
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
    public partial class ManageEmployeeForm : Form
    {
        ManageEmployeesDataAccess da = new ManageEmployeesDataAccess();

        List<EmployeeModel> employees;

        EmployeeModel selectedEmployee;


        public ManageEmployeeForm()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            Clear();

            employees = da.GetEmployees();
            Table.DataSource = employees;
        }

        void Reload()
        {
            employees = da.GetEmployees();
            Table.DataSource = employees;
        }

        void Clear()
        {
            selectedEmployee = null;

            InputEmployeeId.Clear();
            InputName.Clear();
            InputEmail.Clear();
            InputHandphone.Clear();

            InputPosition.SelectedIndex = -1;
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var employee = employees[e.RowIndex];

            //if(selectedEmployee != null && employee.EmployeeID == selectedEmployee.EmployeeID)
            //{
            //    Clear();
            //    return;
            //}

            selectedEmployee = employee;

            InputEmployeeId.Text = employee.EmployeeID;
            InputName.Text = employee.Name;
            InputEmail.Text = employee.Email;
            InputHandphone.Text = employee.Handphone;
            InputPosition.Text = employee.Position;
            InputPosition.SelectedIndex = employee.GetPositionIndex();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                da.InsertEmployee(new EmployeeModel
                {
                    EmployeeID = InputEmployeeId.Text,
                    Name = InputName.Text,
                    Email = InputEmail.Text,
                    Handphone = InputHandphone.Text,
                    Position = InputPosition.Text
                });

                Init();
            }
            catch (Exception ex)
            {
                //gagal insert
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateEmployee(new EmployeeModel
                {
                    EmployeeID = InputEmployeeId.Text,
                    Name = InputName.Text,
                    Email = InputEmail.Text,
                    Handphone = InputHandphone.Text,
                    Position = InputPosition.Text
                });

                Reload();
            }
            catch (Exception)
            {

                //Update gagal
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                da.DeleteEmployee(selectedEmployee.EmployeeID);

                Reload();
                Clear();                
            }
            catch (Exception)
            {
                // delete gagal
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["AdminNavForm"].Show();
        }
    }
}
