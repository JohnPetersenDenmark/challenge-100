using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLUEFRAGMENT.Challenge100
{
    class Challenge100
    {
        

        

        public T[] FindMinMax<T>(T[] arrayOfNumbers) where T : IComparable<T>
        {           
            Array.Sort(arrayOfNumbers);

            T[] resultArray = { arrayOfNumbers[arrayOfNumbers.GetLowerBound(0)], arrayOfNumbers[arrayOfNumbers.GetUpperBound(0)] };

            return (resultArray);
        }

      
        public string NameShuffle(string fullName)
        {
            if ( String.IsNullOrEmpty(fullName))
            {
                return null;
            }
            string[] nameArray = fullName.Split(' ');

            return (nameArray[1] + ' ' + nameArray[0]);
        }

        public bool SameCase(string stringToCaseTest)
        {          
            bool upperCaseFlag = false;
            bool lowerCaseFlag = false;

            foreach ( var character in stringToCaseTest)
            {
                if (character >= 'A' && character <= 'Z' && !upperCaseFlag)
                {
                    upperCaseFlag = true;
                }
                if (character >= 'a' && character <='z' && !lowerCaseFlag)
                {
                    lowerCaseFlag = true;
                }
                if (lowerCaseFlag && upperCaseFlag)
                {
                    return false;
                }
            }
            return upperCaseFlag ^ lowerCaseFlag;
        }

        public bool IsIsogram(string stringToIsogramTest)
        {
            int index = 0;
            int lastPosInSourceString = stringToIsogramTest.Length - 1;
            

            foreach ( var character in stringToIsogramTest)
            {
                if ((index + 1) <= lastPosInSourceString)
                {
                    int pos = stringToIsogramTest.IndexOf(character.ToString(), index +1, StringComparison.InvariantCultureIgnoreCase);
                    if (pos > index)
                    {
                        return false;
                    }

                }
                index++;
            }
            return true;
        }

        public string MonthName(int MonthNumber)
        {
            string[] monthNamearray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return (monthNamearray[MonthNumber - 1]);
        }

        public string AlphabetIndex (string stringToIndex)
        {
            string result = "";
          
            foreach (var character in stringToIndex)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    result = result + (character - 64).ToString() + " " ;
                }
                if (character >= 'a' && character <= 'z')
                {
                    result = result + (character - 96).ToString() + " ";
                }               
            }

            return result;
        }
    }
}
