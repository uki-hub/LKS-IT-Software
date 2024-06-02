using RumahSakit.Lib;
using RumahSakit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.DataAccess
{
    public class ResepsionisDataAccess
    {
        Database db = new Database();

        public void DaftarPasien(PasienModel pasien)
        {
            var newID = new CommonDataAccess().GeneratePasienID();

            db.Execute($@"
                insert into Pasien
                (
                    ID,
                    Nama,
                    NoHP,
                    Kelamin,
                    Umur,
                    Photo,
                    Selesai
                )
                values
                (
                    '{newID}',
                    '{pasien.Nama}',
                    '{pasien.NoHP}',
                    '{pasien.Kelamin}',
                    {pasien.Umur},
                    '{pasien.Photo}',
                    'N'
                )
            ");
        }

        public void DaftarMembership(MembershipModel membership)
        {
            var dt = db.Read($"select * from membership where NoHP = '{membership.NoHP}'");

            if(dt.Rows.Count > 0) throw new Exception("Nomor HP sudah terdaftar");

            var newMembeshipID = new CommonDataAccess().GenerateUserID("membership");

            db.Execute($@"
                insert into [User]
                (
                    ID,
                    Username,
                    Password,
                    Posisi
                )
                values
                (
                    '{newMembeshipID}',
                    '{membership.NoHP}',
                    '{Common.Encrypt(membership.NoHP)}',
                    'membership'
                )
            ");

            db.Execute($@"
                insert into Membership
                (
                    UserID,
                    Nama,
                    NoHP,
                    Expired
                )
                values
                (
                    '{newMembeshipID}',
                    '{membership.Nama}',
                    '{membership.NoHP}',
                    '{membership.Expired}'
                )
            ");
        }

        public List<PasienModel> GetListPasien()
        {
            var dt = db.Read("select * from Pasien where Selesai = 'N' ");

            var listPasien = new List<PasienModel>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                listPasien.Add(new PasienModel
                {
                    ID = data["ID"].ToString(),
                    Nama = data["Nama"].ToString(),
                    NoHP = data["NoHP"].ToString(),
                    Kelamin = data["Kelamin"].ToString(),
                    Umur = int.Parse(data["Umur"].ToString()),
                    Photo = data["Photo"].ToString(),
                    NomorAntrian = int.Parse(data["NomorAntrian"].ToString()),
                });
            }

            return listPasien;
        }
    }
}
