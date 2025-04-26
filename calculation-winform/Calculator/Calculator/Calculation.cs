using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        private int a, b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get { return a; } }
        public int B { get { return b; } }

            public int Execute(string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "add":
                    result = Add(a, b);
                    break;
                case "subtract":
                    result = Subtract(a,b);
                    break;
                case "multiply":
                    result = Multiply(a,b);
                    break;
                case "divide":
                    result = Divide(a, b);
                    break;
            }
            return result;
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }   

        private int Multiply(int a, int b)
        {
            return a * b;
        }   

        private int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
