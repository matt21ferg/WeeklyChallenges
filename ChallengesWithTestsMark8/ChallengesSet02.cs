using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
             return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           return vals.Length % 2 != 0 ? false : true;
            
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
            
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false ;
            
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
           return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
               

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length >= str2.Length ? str2.Length : str1.Length;
                                
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
           
        }

        public int SumEvens(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Where(x => x % 2 == 0).Sum();
            //if(numbers == null)
            // return 0;
            //var SumEvans = 0;
            //foreach (var item in numbers)
            //{
            //         if (item % 2 == 0)
            //            SumEvans += item;

            //}
            //return SumEvans;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : numbers.Sum() % 2 != 0;
            //if (numbers == null) 
            //    return false;
            //var sum = 0;    
            //foreach (var num in numbers)
            //{
            //    sum = sum + num;
            //}
            //if(sum % 2 != 0)
            //return true;
            //else return false;



        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // var posOdds = number / 2;
            return number < 0 ? 0 : number / 2;
            //if (posOdds < 0)
            //    return 0;
            //else return posOdds;
            

        }


    }
}
