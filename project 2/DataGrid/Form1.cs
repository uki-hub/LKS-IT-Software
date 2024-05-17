using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var data = new List<Barang>();
            data.Add(new Barang
            {
                ID = 1,
                No = 1256,
                Nama = "Laptop",
                Harga = 100000,
                Deskripsi = "Deskripsi Laptop",
            });
            data.Add(new Barang
            {
                ID = 1,
                No = 12344,
                Nama = "Handphone",
                Harga = 100000,
                Deskripsi = "Deskripsi Handphone",
            });
            data.Add(new Barang
            {
                ID = 1,
                No = 56755,
                Nama = "Komputer",
                Harga = 150000,
                Deskripsi = "Deskripsi Komputer",
            });

            InitializeComponent();

            var dt = new DataTable();

            dt.Columns.Add("No");
            dt.Columns.Add("Nama Barang");
            dt.Columns.Add("Harga Barang");
            dt.Columns.Add("Deskripsi Barang");


            foreach (var item in data)
            {
                dt.Rows.Add(item.No, item.Nama, item.Harga, item.Deskripsi);
            }

            var mappedData = data.Select(x => new
            {
                No = x.No,
                Nama = x.Nama,
                Harga = x.Harga,
                Deskripsi = x.Deskripsi,
            }).ToList();

            Table.DataSource = mappedData;
        }

        class Barang
        {
            public int ID { get; set; }
            public int No { get; set; }
            public string Nama { get; set; }
            public double Harga { get; set; }
            public string Deskripsi { get; set; }
        }
    }
}
