using RumahSakit.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.Lib
{
    public class Common
    {

		public static string Encrypt(string text)
		{
			string hasil = "";

			using (var md5 = MD5.Create())
			{
				var textBytes = Encoding.ASCII.GetBytes(text);

				var hash = md5.ComputeHash(textBytes);

                for (int i = 0; i < hash.Length; i++)
                {
					hasil += hash[i].ToString("X2").ToLower();
                }
			}

			return hasil;
		}

		public static void ClearData()
        {
			MainStore.User = null;
        }
	}
}
