using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.lib
{
    public class Common
    {
		public static string Sha512(string text)
		{
			string hasil = "";

			using (var sha = SHA512.Create())
			{
				var textBytes = Encoding.UTF8.GetBytes(text);

				var hash = sha.ComputeHash(textBytes);

				for (int i = 0; i < hash.Length; i++)
				{
					hasil += hash[i].ToString("X2").ToLower();
				}
			}

			return hasil;
		}

		public static DateTime? objectToDateTime(object o)
        {
			if (o == null || o == DBNull.Value) return null;

			if (o is DateTime) return (DateTime)o;


			return DateTime.Parse(o.ToString());
        }

		public static List<O> mapData<T, O>(List<T> list, Func<T, int, O> selector)
        {
			if (list == null) return null;

			List<O> result = new List<O>();

            for (int i = 0; i < list.Count; i++) result.Add(selector(list[i], i));

			return result;
		}
	}
}
