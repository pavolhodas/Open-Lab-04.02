using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            int l = 0;
            string fly = "";
            while (l <= original.Length - 1)
            {
                fly += original[l];
                fly += original[l];
                l++;
            }
            return fly;
        }
    }
}
