using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran3.Data
{
    public class GeneratorId
    {
        public static string generateRandomString(int len)
        {
            String stringTemp = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string result = "";
            Random ran = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = ran.Next(stringTemp.Length);
                result += stringTemp[index];
            }

            return result;
        }

        public static string generateId(String template)
        {
            return template + "-" + generateRandomString(4);
        }
    }
}
