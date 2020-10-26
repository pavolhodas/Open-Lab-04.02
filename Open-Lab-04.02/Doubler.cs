using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            int l = 0;
            string letter = "";
            while (l <= original.Length - 1)
            {
                letter += original[l];
                letter += original[l];
                l++;
            }
            return letter;
        }
    }
}
