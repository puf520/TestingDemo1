﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0;

        }
        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}

