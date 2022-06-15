using System;


namespace AliErenKayhanCalculatorHomework
{
    class Program
    {

        static void Welcome() // this is a method
        {
            Console.WriteLine("Hello and Welcome to Calculator Made by Ali Eren Kayhan");
            Console.WriteLine("---------------------------------------------------------------------");

        }

        static void calculate()
        {
            operators opr = new operators(); // Create a opr object
            opr.getnumbers(); // To get number from the users
            opr.getnumbers2(); // To get number from the users
            opr.choice();    // To get operation from the users
        }
       
        static void again()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Do you want to use the calculator again? (Y/N)");
            char choice2 = Convert.ToChar(Console.ReadLine());
            if (choice2 == 'Y' || choice2 == 'y')
            {
                Console.Clear();
                Welcome();
                calculate();
                again();
            }
            else if (choice2 == 'N' || choice2 == 'n')
            {
                Console.WriteLine("---------------------------------------------------------------------");

                Console.WriteLine("Thank you for using the Calculator made by Ali Eren Kayhan \n" +
                                  "I hope you like it. See you later.");
            }
            else
            {
                Console.WriteLine("Please enter one of these (Y,y,N,n)");
                again();
            }
        }

        static void Main(string[] args)
        {

            Welcome(); // with this, we can call the method.
            calculate();
            again();
            Console.ReadKey();
    }
}
}