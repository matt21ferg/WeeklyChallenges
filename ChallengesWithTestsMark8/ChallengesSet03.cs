using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
                return true;
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers is null || numbers.Count() == 0)
                return false;


            var sum = numbers.Where(x => x % 2 != 0).Sum();
            return sum % 2 != 0;
        }   

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
                var number = false;
                var lower = false;
            foreach (var letter in password)
            {
                if (int.TryParse(letter.ToString(), out int x))
                { number = true; }
              else if (letter.ToString() == letter.ToString().ToUpper())
                { upper = true; }
                else if (letter.ToString() == letter.ToString().ToLower())
                { lower = true; }
            }
                        return number && upper && lower;
                        
                        
                        
            
            
         
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)  return 0; 
            else return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
          
        }

        public int[] GetOddsBelow100()
        {
            int[] arr = new int[100];
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr.Where(x => x % 2 != 0 ).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int counter = 0;
            foreach (var item in words)
            {
                words[counter] = item.ToUpper();
                counter++;
            }
            Console.WriteLine(words); 
        }
    }
}
