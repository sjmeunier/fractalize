using System;

namespace UtilLib
{
	/// <summary>
	/// Summary description for Morse.
	/// </summary>
	public class Morse
	{
		private string[,] Chars;
		private int iCharCount;

		public Morse()
		{
			iCharCount = 39;
			Chars = new string[iCharCount, 2];

			Chars[0, 0] = "A";
			Chars[0, 1] = ".-";
			Chars[1, 0] = "B";
			Chars[1, 1] = "-...";
			Chars[2, 0] = "C";
			Chars[2, 1] = "-.-.";
			Chars[3, 0] = "D";
			Chars[3, 1] = "-..";
			Chars[4, 0] = "E";
			Chars[4, 1] = ".";
			Chars[5, 0] = "F";
			Chars[5, 1] = "..-.";
			Chars[6, 0] = "G";
			Chars[6, 1] = "--.";
			Chars[7, 0] = "H";
			Chars[7, 1] = "....";
			Chars[8, 0] = "I";
			Chars[8, 1] = "..";
			Chars[9, 0] = "J";
			Chars[9, 1] = ".---";
			Chars[10, 0] = "K";
			Chars[10, 1] = "-.-";
			Chars[11, 0] = "L";
			Chars[11, 1] = ".-..";
			Chars[12, 0] = "M";
			Chars[12, 1] = "--";
			Chars[13, 0] = "N";
			Chars[13, 1] = "-.";
			Chars[14, 0] = "O";
			Chars[14, 1] = "---";
			Chars[15, 0] = "P";
			Chars[15, 1] = ".--.";
			Chars[16, 0] = "Q";
			Chars[16, 1] = "--.-";
			Chars[17, 0] = "R";
			Chars[17, 1] = ".-.";
			Chars[18, 0] = "S";
			Chars[18, 1] = "...";
			Chars[19, 0] = "T";
			Chars[19, 1] = "-";
			Chars[20, 0] = "U";
			Chars[20, 1] = "..-";
			Chars[21, 0] = "V";
			Chars[21, 1] = "...-";
			Chars[22, 0] = "W";
			Chars[22, 1] = ".--";
			Chars[23, 0] = "X";
			Chars[23, 1] = "-..-";
			Chars[24, 0] = "Y";
			Chars[24, 1] = "-.--";
			Chars[25, 0] = "Z";
			Chars[25, 1] = "--..";
			Chars[26, 0] = "0";
			Chars[26, 1] = "-----";
			Chars[27, 0] = "1";
			Chars[27, 1] = ".----";
			Chars[28, 0] = "2";
			Chars[28, 1] = "..---";
			Chars[29, 0] = "3";
			Chars[29, 1] = "...--";
			Chars[30, 0] = "4";
			Chars[30, 1] = "....-";
			Chars[31, 0] = "5";
			Chars[31, 1] = ".....";
			Chars[32, 0] = "6";
			Chars[32, 1] = "-....";
			Chars[33, 0] = "7";
			Chars[33, 1] = "--...";
			Chars[34, 0] = "8";
			Chars[34, 1] = "---..";
			Chars[35, 0] = "9";
			Chars[35, 1] = "----.";
			Chars[36, 0] = ".";
			Chars[36, 1] = ".-.-.-";
			Chars[37, 0] = ",";
			Chars[37, 1] = "--..--";
			Chars[38, 0] = "?";
			Chars[38, 1] = "..--..";
		}

		public string GetLetterChar(string psMorse)
		{
			int i;

			for (i = 0; i < iCharCount; i++)
			{
				if (Chars[i, 1] == psMorse)
				{
					return Chars[i, 0].Trim();
				}
			}
			return psMorse;
		}

		public string GetMorseChar(string psLetter)
		{
			int i;

			for (i = 0; i < iCharCount; i++)
			{
				if (Chars[i, 0] == psLetter.ToUpper())
				{
					return Chars[i, 1];
				}
			}
			return psLetter;
		}

		public string GetMorse(string psLetters)
		{
			int i;
			string sMorse = "";

			for (i = 0; i < psLetters.Length; i++)
			{
				sMorse += " " + GetMorseChar(psLetters.Substring(i, 1));
			}
			sMorse = sMorse.Trim();
			return sMorse;
		}

		public string GetText(string psMorse)
		{
			int i;
			string sLetters = "";
			string sMorseChar;

			psMorse = psMorse.Trim();
			psMorse += " ";

			while (psMorse.Length > 0)
			{
				i = psMorse.IndexOf(" ", 0);
				sMorseChar = psMorse.Substring(0, i + 1);
				psMorse = psMorse.Substring(i + 1);
				if (sMorseChar == " ")
				{
					sLetters += " ";
				}
				else
				{
					sLetters += GetLetterChar(sMorseChar.Trim());
				}
			}
			sLetters = sLetters.Trim();
			return sLetters;
		}
	}
}
