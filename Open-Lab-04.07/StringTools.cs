using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            
 char[] A = original.ToCharArray();
    string Empty = String.Empty;
    for (int i = A.Length - 1; i > -1; i--)
    {
        Empty += A[i];
    } 
    return Empty;
}
        }
}
