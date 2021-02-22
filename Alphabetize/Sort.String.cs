using System;

namespace Alphabetize
{
    public class SortString
    {

        public static string StringSort(string inputString) 
        {

            string outputString = "";

            string alpabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

          
            for (int i = 0; i < alpabet.Length; i++)
            {
                for (int j = 0; j < inputString.Length ; j++) 
                {
                    if (inputString[j] == alpabet[i])
                    { 
                        outputString += alpabet[i];
                    }
                }
            }
            return outputString;
        }
    }
}
