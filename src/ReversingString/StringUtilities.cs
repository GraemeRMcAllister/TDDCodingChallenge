using System;
using System.Text;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {

            char[] sAarry = s.ToCharArray();


            for (int i = 0; i < s.Length / 2; i++)
            {

                char temp = sAarry[i];

                sAarry[i] = sAarry[sAarry.Length - 1 - i];

                sAarry[sAarry.Length - 1 - i] = temp;

            }
            return new string(sAarry);
        }

        //public static string Reverse(string s)
        //{
        //    char[] result = s.ToCharArray();

        //   Array.Reverse(result);

        //    return new string(sAarry);
        //}
    }
}
