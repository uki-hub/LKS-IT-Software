using HotelSmkJatiLKS.db;
using HotelSmkJatiLKS.models;
using HotelSmkJatiLKS.store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.dataaccess
{
    public class ReservationDataAccess
    {
        Database db = new Database();

        public List<CustomerModel> GetCustomer()
        {
            var result = new List<CustomerModel>();

            var dt = db.Read("select * from Customer");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new CustomerModel
                {
                    ID = int.Parse(data["ID"].ToString()),
                    Name = data["Name"].ToString(),
                    NIK = data["NIK"].ToString(),
                    Email = data["Email"].ToString(),
                    Gender = data["Gender"].ToString(),
                    Age = int.Parse(data["Age"].ToString()),
                    PhoneNumber = data["PhoneNumber"].ToString()
                });
            }

            return result;
        }

        public List<RoomTypeModel> GetRoomTypes()
        {
            return new RoomTypeDataAccess().GetRoomTypes();
        }

        public List<RoomModel> GetRoom(int roomTypeID)
        {
            var result = new List<RoomModel>();

            var dt = db.Read($"select * from Room where RoomTypeID = ${roomTypeID}");

            for (int i = 0; i < dt.Rows.Count; i++)
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

        public List<ItemModel> GetItems()
        {
            var result = new List<ItemModel>();

            var dt = db.Read("select * from Item");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new ItemModel
                {
                    ID = int.Parse(data["ID"].ToString()),
                    Name = data["Name"].ToString(),
                    RequestPrice = double.Parse(data["RequestPrice"].ToString()),
                    CompensationFee = double.Parse(data["CompensationFee"].ToString())
                });
            }

            return result;
        }



        public void AddCustomer(CustomerModel newCustomer)
        {
            db.Execute($@"
                insert into customer
                (
                Name,
                NIK,
                Email,
                Gender,
                PhoneNumber,
                Age
                )
                values
                (
                '{newCustomer.Name}',
                '{newCustomer.NIK}',
                '{newCustomer.Email}',
                '{newCustomer.Gender}',
                '{newCustomer.PhoneNumber}',
                {newCustomer.Age}
                )
            ");
        }

        public void AddReservation(ReservationModel newReservation)
        {
            db.Execute($@"
                insert into Reservation
                (
                CustomerID,
                EmployeeID,
                DateTime,
                BookingCode,
                )
                values
                (
                {newReservation.CustomerID},
                0,
                GETDATE(),
                '{newReservation.BookingCode}'
                )
            ");
        }
    }

}
