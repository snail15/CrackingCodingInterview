using System;

namespace CrackingCodingInterview.ArraysAndString
{
    public class IsUnique
    {
        public bool IsUniqueElement(string s)
        {
            if(s.Length > 128) return false;

            bool[] arr = new bool[128];
            foreach (char c in s)
            {
                int val = c;
                if(arr[val]) return false;
                arr[val] = true;
            }

            return true;
        }
    }
}
