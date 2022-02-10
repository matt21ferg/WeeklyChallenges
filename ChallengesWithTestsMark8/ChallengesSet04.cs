using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var Counter = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                { Counter += item; }
                else
                { Counter -= item; }
            }
            return Counter;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var length = 50;
            var strList = new List<string>();
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            foreach (var item in strList)
            {
                if(item.Length < length)
                { length = item.Length; }
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var result = 100;
            var numList = new List<int>();
            numList.Add(number4);
            numList.Add(number1);
            numList.Add(number2);
            numList.Add(number3);
            foreach (var num in numList)
            {
                if (num < result)
                { result = num; }
            }
            return result;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name ="TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var counter = 0;
            var triangle = new List<int>();
            triangle.Add(sideLength1);
            triangle.Add(sideLength2);
            triangle.Add(sideLength3);

           if(sideLength1 + sideLength2 > sideLength3)
            { counter++; }
           if(sideLength2 + sideLength3 > sideLength1)
            { counter++; }
           if(sideLength3 + sideLength1 > sideLength2)
            { counter++; }
            if (counter == 3)
            { return true; }
            else { return false; }
        
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out  double u))
            { return true; }
            else
            { return false; }   
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var counter = 0;
            foreach (var obj in objs)
            {
                if (obj is null)
                    counter++;
            }
            if (counter > (objs.Length / 2))
            { return true; }
           else return false;
                         
                                   
        }

        public double AverageEvens(int[] numbers)
        {

           
            if (numbers is null || numbers.Length == 0)
            { return 0; }
            else 
            {
                var evens = numbers.Where(x => x % 2 == 0);
               return (evens.Count() == 0) ? 0 : evens.Average();
            }

            
        }

        public int Factorial(int number)
        {

            return number ==0 ? 1 : Enumerable.Range(1,number).Aggregate((num, i)=> num * i );
            //if(number < 0)
            //{ throw new ArgumentOutOfRangeException(); }
            //if (number == 0)
            //{ return 1; }
            //var num1 = 1;
            

            //do
            //{
            //    num1 = num1 * (number--);
                


            //} while (number > 1);
            //return (number == 0) ? 1 : num1;




        }
    }
}
