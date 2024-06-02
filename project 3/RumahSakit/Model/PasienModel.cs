using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.Model
{
    public class PasienModel
    {
        public string ID { get; set; }
        public string Nama { get; set; }
        public string NoHP { get; set; }
        public string Kelamin { get; set; }
        public int Umur { get; set; }
        public string Photo { get; set; }
        public int NomorAntrian { get; set; }
    }
}
