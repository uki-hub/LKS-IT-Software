using HotelSmkJatiLKS.db;
using HotelSmkJatiLKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.dataaccess
{
    public class RoomTypeDataAccess
    {
        Database db = new Database();

        public List<RoomTypeModel> GetRoomTypes()
        {
            var result = new List<RoomTypeModel>();

            var dt = db.Read($"select * from RoomType");

            for (int i = 0;  i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new RoomTypeModel
                {
                    ID = data["ID"].ToString(),
                    Name = data["Name"].ToString(),
                    Capacity = int.Parse(data["Capacity"].ToString()),
                    RoomPrice = double.Parse(data["RoomPrice"].ToString()),
                    Photo = data["Photo"].ToString()
                });
            }
            return result;
        }

        public void InsertRoomType(RoomTypeModel newRoomType)
        {
            db.Execute($@"
                insert into RoomType
                (
                ID,
                Name,
                Capacity,
                RoomPrice,
                Photo
                )
                values
                (
                '{newRoomType.ID}',
                '{newRoomType.Name}',
                '{newRoomType.Capacity}',
                '{newRoomType.RoomPrice}',
                '{newRoomType.Photo}'
                )
                
            ");
        }

        public void UpdateRoomType(RoomTypeModel updateRoomType)
        {
            db.Execute($@"
                update RoomType set
                        ID = '{updateRoomType.ID}',
                        Name = '{updateRoomType.Name}',
                        Capacity = '{updateRoomType.Capacity}',
                        RoomPrice = '{updateRoomType.RoomPrice}',
                        Photo = '{updateRoomType.Photo}'
                ");
        }

        public void Save(List<RoomTypeModel> roomTypes)
        {
            //Clear Data di table RoomType
            db.Execute("Delete from RoomType");

            foreach (var roomType in roomTypes)
            {
                db.Execute($@"
                    insert into RoomType
                    (
                    Name,
                    Capacity,
                    RoomPrice,
                    Photo
                    )
                    values
                    (
                    '{roomType.Name}',
                    '{roomType.Capacity}',
                    '{roomType.RoomPrice}',
                    '{roomType.Photo}'
                    )
                ");
            }
        }
    }
}
