using System;

namespace Barcoma_Act10
{
    public class FunctionOne
    {
        public void CheckParity()
        {
            Console.Write("Enter a byte: ");
            string bits = Console.ReadLine();

            // Check if the input only consists of 1's and 0's
            foreach (char bit in bits)
            {
                if (bit != '0' && bit != '1')
                {
                    Console.WriteLine("Invalid input. Please enter a byte (1's and 0's only).");
                    return;
                }
            }

            Console.Write("Enter parity (E for even, O for odd): ");
            char parityInput = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            bool isEvenParity = parityInput == 'E';

            int count = 0;
            foreach (char bit in bits)
            {
                if (bit == '1')
                {
                    count++;
                }
            }

            if (isEvenParity)
            {
                Console.WriteLine(count % 2 != 0 ? "\nERROR: The byte does not have even parity.\n\n" : "The byte has even parity.\n\n");
            }
            else
            {
                Console.WriteLine(count % 2 == 0 ? "\nERROR: The byte does not have odd parity.\n\n" : "The byte has odd parity.\n\n");
            }
        }
    }
}
