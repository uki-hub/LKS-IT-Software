using HotelSmkJatiLKS.db;
using HotelSmkJatiLKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.dataaccess
{
    public class RoomDataAccess
    {
        Database db = new Database();

        public List<RoomModel> GetRooms()
        {
            var result = new List<RoomModel>();

            var dt = db.Read($"select * from Room");

            for (int i = 0;  i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new RoomModel
                {
                    RoomNumber = data["RoomNumber"].ToString(),
                    RoomTypeID = data["RoomTypeID"].ToString(),
                    RoomFloor = data["RoomFloor"].ToString(),
                    Description = data["Description"].ToString()
                });
            }
            return result;
        }

        public List<RoomTypeModel> GetRoomTypes()
        {
            return new RoomTypeDataAccess().GetRoomTypes();
        }     
    }
}
