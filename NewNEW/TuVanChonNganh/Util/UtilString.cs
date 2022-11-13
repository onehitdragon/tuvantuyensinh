using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace TuVanChonNganh.Util
{
    public class UtilString
    {
        public static string ConvertStringToId(string value)
        {
            string valueClone = value;
            valueClone = valueClone.Trim();
            valueClone = valueClone.ToUpper();
            string result = "";
            bool requireAdd = true;
            for (int i = 0; i < valueClone.Length; i++)
            {
                if (requireAdd && new Regex(@"^[A-Z]$").IsMatch(valueClone[i].ToString()))
                {
                    result += valueClone[i];
                    requireAdd = false;
                }
                if (valueClone[i].Equals(' '))
                {
                    requireAdd = true;
                }
            }

            return result;
        }
    }
}