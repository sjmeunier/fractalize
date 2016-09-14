using System;
using System.Collections.Generic;
using System.Text;

namespace UtilLib
{
    public static class HexLib
    {
        public static int HexToInt(String hexstr)
        // This method converts a hexvalues string as 80FF into a integer.
        //    Note that you may not put a '#' at the beginning of string! There
        // is not much error checking in this method. If the string does not
        // represent a valid hexadecimal value it returns 0.
        {
            int counter, hexint;
            char[] hexarr;
            hexint = 0;
            hexstr = hexstr.ToUpper();
            hexarr = hexstr.ToCharArray();
            for (counter = hexarr.Length - 1; counter >= 0; counter--)
            {
                if ((hexarr[counter] >= '0') && (hexarr[counter] <= '9'))
                {
                    hexint += (hexarr[counter] - 48) * ((int)(Math.Pow(16, hexarr.Length - 1 - counter)));
                }
                else
                {
                    if ((hexarr[counter] >= 'A') && (hexarr[counter] <= 'F'))
                    {
                        hexint += (hexarr[counter] - 55) * ((int)(Math.Pow(16, hexarr.Length - 1 - counter)));
                    }
                    else
                    {
                        hexint = 0;
                        break;
                    }
                }
            }
            return hexint;
        }

        public static String IntToHex(int hexint)
        // This method converts a integer into a hexadecimal string representing the
        // int value. The returned string will look like this: 55FF. Note that there is
        // no leading '#' in the returned string!
        {
            int counter, reminder;
            String hexstr;

            counter = 1;
            hexstr = "";
            while (hexint + 15 > Math.Pow(16, counter - 1))
            {
                reminder = (int)(hexint % Math.Pow(16, counter));
                reminder = (int)(reminder / Math.Pow(16, counter - 1));

                if (reminder <= 9)
                {
                    hexstr = hexstr + (char)(reminder + 48);
                }
                else
                {
                    hexstr = hexstr + (char)(reminder + 55);
                }

                hexint -= reminder;
                counter++;
            }
            return StringLib.Reverse(hexstr);
        }

        public static String IntToHex(int hexint, int length)
        // This version of the IntToHex method returns a hexadecimal string representing the
        // int value in the given minimum length. If the hexadecimal string is shorter then the
        // length parameter the missing characters will be filled up with leading zeroes.
        // Note that the returend string though is not truncated if the value exeeds the length!
        {
            String hexstr, ret;
            int counter;
            hexstr = IntToHex(hexint);
            ret = "";
            if (hexstr.Length < length)
            {
                for (counter = 0; counter < (length - hexstr.Length); counter++)
                {
                    ret = ret + "0";
                }
            }
            return ret + hexstr;
        }
    }
}
