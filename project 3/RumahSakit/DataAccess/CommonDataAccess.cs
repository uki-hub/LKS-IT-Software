using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.DataAccess
{
    public class CommonDataAccess
    {
        Database db = new Database();

        public string GenerateUserID(string posisi)
        {
            var prefix = "";

            switch (posisi)
            {
                case "resepsionis":
                    prefix = "P";
                    break;

                case "doktor":
                    prefix = "D";
                    break;

                case "apoteker":
                    prefix = "A";
                    break;

                case "membership":
                    prefix = "M";
                    break;
            }

            var dt = db.Read($"select top 1 * from [User] where posisi = '{posisi}' order by ID desc ");

            string newID;

            if (dt.Rows.Count == 0)
            {
                newID = $"{prefix}1";
            }
            else
            {
                var lastDigit = int.Parse(dt.Rows[0]["Id"].ToString().Remove(0, 1));
                newID = $"{prefix}{lastDigit + 1}";
            }

            return newID;
        }

        public string GeneratePasienID()
        {
            var dt = db.Read("select top 1 * from Pasien order by ID desc");

            int digit;

            if(dt.Rows.Count == 0)
            {
                digit = 1;
            } else
            {
                digit = int.Parse(dt.Rows[0]["ID"].ToString().Remove(0, 2)) + 1;
            }

            return $"PS{digit}";
        }

        public void ChangePassword(string UserID, string newPasswordSecret)
        {
            db.Execute($"update [User] set password = '{newPasswordSecret}' where ID = '{UserID}'");
        }
    }
}
