using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double RequestPrice { get; set; }
        public double CompensationFee { get; set; }
    }
}
