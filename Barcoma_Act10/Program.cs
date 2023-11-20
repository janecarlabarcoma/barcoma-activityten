using System;

namespace Barcoma_Act10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionOne functionOne = new FunctionOne();
            FunctionTwo functionTwo = new FunctionTwo();
            FunctionThree functionThree = new FunctionThree();
            FunctionFour functionFour = new FunctionFour();

            while (true)
            {
                Console.WriteLine("Error Control\n\n");

                Console.WriteLine("[1] Check Even/Odd Parity Bit");
                Console.WriteLine("[2] Find BCC");
                Console.WriteLine("[3] Check BCC");
                Console.WriteLine("[4] Find BCC & Even/Odd Parity Bits & BCC Parity Bit");
                Console.WriteLine("[5] Exit program.\n");

                Console.Write("Enter your choice: ");
               int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        functionOne.CheckParity();
                        break;
                    case 2:
                        functionTwo.CalculateBCC();
                        break;
                    case 3:
                        functionThree.CheckBCC();
                        break;
                    case 4:
                        functionFour.CalculateParity();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
