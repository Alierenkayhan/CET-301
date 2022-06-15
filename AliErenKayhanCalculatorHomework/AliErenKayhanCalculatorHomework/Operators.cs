using System;
using System.Collections.Generic;
using System.Text;

namespace AliErenKayhanCalculatorHomework
{
    class operators
    {
        protected double numb1, numb2;

        public void getnumbers()    // To get number from the users and this is a constructor      
        {
            try
            {
                Console.Write("Enter your first number: ");
                numb1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException hata) // if users try to enter wrong format,it will catch
            {
                Console.WriteLine("Warning, you enter wrong type of data or you don't enter any number.");
                getnumbers(); // recursive function (calling itself)
            }
         }

        public void getnumbers2()    // To get number from the users and this is a constructor      
        {
            try
            {
                Console.Write("Enter your second number: ");
                numb2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException hata) // if users try to enter wrong format,it will catch
            {
                Console.WriteLine("Warning, you enter wrong type of data or you don't enter any number.");
                getnumbers2(); // recursive function (calling itself)
            }
         }

        public void choice() // To get operation from the users
        {
            Console.Write("Write one of them (+,-,x,/): ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '+':
                    additiondouble(numb1, numb2); // Calling addition function            
                    break;
                case '-':
                    subtraction(numb1, numb2); // Calling subtraction function
                    break;
                case 'x':
                    multiplication(numb1, numb2); // Calling multiplication function
                    break;
                case '/':
                    division(numb1, numb2); // Calling divide function
                    break;
                default:
                    Console.WriteLine("Warning, please write one of them (+,-,x,/)");
                    
                    break;
            }
        }

        public double additiondouble(double numb1, double numb2) // A function that adds the numbers 
        {
            double additiondouble = numb1 + numb2;
            Console.WriteLine("The addition of " + numb1 + " and " + numb2 + " is = " + additiondouble);
            return additiondouble;
        }

        public double subtraction(double numb1, double numb2)  // A function that subtracts the numbers 
        {
            double subtraction = numb1 - numb2;
            Console.WriteLine("The subtraction of " + numb1 + " and " + numb2 + " is = " + subtraction);
            return subtraction;
        }

        public double multiplication(double numb1, double numb2)  // A function that multiples the numbers 
        {
            double multiplication = numb1 * numb2;
            Console.WriteLine("The multiplication of " + numb1 + " and " + numb2 + " is = " + multiplication);
            return multiplication;
        }

        public double division(double numb1, double numb2)  // A function that divides the numbers 
        {
            double division;
            string division1;

            division = numb1 / numb2;
            if (numb1 != 0 && numb2 == 0) // for the situation of  number / 0 
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.Write("You are trying to divide a number except 0 to 0 \n");
                division1 = "Infinity";
                Console.WriteLine("The division of " + numb1 + " and " + numb2 + " is = " + division1);

            }
            else if (numb1 == 0 && numb2 == 0) // for the situation of 0 / 0 
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.Write("Warning.You are trying to divide 0 to 0 \n");
                division1 = "Error";
                Console.WriteLine("The division of " + numb1 + " and " + numb2 + " is = " + division1);

            }
            else
            {
                Console.WriteLine("The division of " + numb1 + " and " + numb2 + " is = " + division);

            }
            return division;
        }

     }
}
