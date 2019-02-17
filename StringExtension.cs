using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if (array==null)
                throw new ArgumentNullException();
            foreach (string str in array)
            {
                if(str==null)
                    throw new ArgumentNullException();
            }
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j-1].Length > array[j].Length)
                {
                    string temp = array[j]; 
                    array[j] = array[j-1];
                    array[j-1] = temp;
                    j--;
                }
            }
            //2 1 4 5 6
        }
    }
}
