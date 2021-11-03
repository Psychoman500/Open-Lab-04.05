using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string i = "";
            for (int letter = 0; letter < orig.Length; letter++)
            {
                for (int repeated = 0; repeated < n; repeated++)
                {
                    i += orig[letter].ToString();
                }
            }
            return i;
        }

    }
}
