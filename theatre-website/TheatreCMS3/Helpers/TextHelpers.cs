using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Helpers
{
	public static class TextHelpers
	{
        public static string LimitChar(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }

        public static string LimitWords(string value, int maxWords)
        {
            maxWords++;

            int l = 0;
            int wrd = 1;

            if (maxWords < 1 || value == null)
                return value;

            if (value[0] == ' ')
            {
                wrd--;
            }

            for (int i = 0; i < value.Length && wrd < maxWords; i++)
            {
                if ((value[i] == ' ' || value[i] == '\t' || value[i] == '\n') && (value[i+1] != ' '))
                {
                    wrd++;
                }
                l++;
            }

            if (maxWords > wrd)
            {
                return value;
            }

            int endPoint;

            if ((value.IndexOf(" ", l)) == -1)
            {
                endPoint = l - 1;
            }
            else
                endPoint = value.IndexOf(" ", l-1);

            return value.Substring(0, endPoint) + "...";

        }
    }
}