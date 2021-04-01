using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int result;
            if (number2 < number1)
                result = number2;
            else
                result = number1;
            return result;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            int result;
            if (number3 < number2)
                result = (int)number3;
            else
            if (number2 < number1)
                result = number2;
            else
                result = number1;
            return result;
        }
        public int FindMaximum(int number1, int number2)
        {
            int result;
            if (number2 > number1)
                result = number2;
            else
                result = number1;
            return result;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            int result;
            if (number3 > number2)
                result = (int)number3;
            else
                if (number2 > number1)
                result = number2;
            else
                result = number1;
            return result;
        }
    }
}