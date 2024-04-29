using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.models
{
    public class RoomModel
    {
        public string RoomNumber { get; set; }
        public string RoomTypeID { get; set; }
        public string RoomFloor {  get; set; }
        public string Description { get; set; }


        public int GetRoomTypeIndex()
        {
            switch (RoomTypeID)
            {
                case "Standard Twin Bed":
                    return 0;

                case "Standard Double Bed":
                    return 1;

                default:
                    return -1;
            }
        }
    }
}
