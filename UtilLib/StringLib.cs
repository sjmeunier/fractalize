using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLib
{
    public static class StringLib
    {
        public static string Reverse(string sStr)
        {
            string sTemp = "";

            for (int i = sStr.Length - 1; i >= 0; i--)
            {
                sTemp += sStr[i].ToString();
            }
            return sTemp;
        }

        public static bool IsPalindrome(string sStr)
        {
            string sRevStr = Reverse(sStr);
            if (sRevStr.ToLower() == sStr.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
