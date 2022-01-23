using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var subAnswer = (minuend - subtrahend);
            return subAnswer;
        }

        public int Add(int number1, int number2)
        {
            var sum = (number1 + number2);
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return number1 > number2 ? number2 : number1;
            //if(number1 > number2)
            //{ return number2; }
            //else { return number1; }
        }

        public long Multiply(long factor1, long factor2)
        {
            var product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";
            //if (string.IsNullOrEmpty(nameOfPerson))
            //{ return "Hello!"; }
            //else         
            //return $"Hello, {nameOfPerson}!";
        }

        public string GetHey()
        {
             return "HEY!";
        }
    }
}
