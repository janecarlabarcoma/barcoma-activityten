using System;
using System.Linq;

namespace Barcoma_Act10
{
    public class FunctionThree
    {
        public void CheckBCC()
        {
            Console.Write("Enter the number of blocks: ");
            int numberOfBlocks = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of bits: ");
            int bitLength = int.Parse(Console.ReadLine());

            int[] bitBlocks = new int[numberOfBlocks];
            for (int i = 0; i < numberOfBlocks; i++)
            {
                while (true)
                {
                    Console.Write($"Enter block {i + 1}: ");
                    string input = Console.ReadLine();

                    // Check if the block only consists of 1's and 0's
                    if (input.All(c => c == '0' || c == '1'))
                    {
                        // Check if the length of the block exceeds the bitLength
                        if (input.Length > bitLength)
                        {
                            Console.WriteLine($"\nInvalid input. The length of the block exceeds the specified bit length of {bitLength}.\n\n");
                            return;
                        }

                        bitBlocks[i] = Convert.ToInt32(input, 2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter a binary number (0 and 1 only).\n\n");
                    }
                }
            }

            Console.Write("Enter the BCC: ");
            string inputBCCString = Console.ReadLine();
            int inputBCC = Convert.ToInt32(inputBCCString, 2);

            // Calculate BCC
            int calculatedBCC = bitBlocks[0];
            for (int i = 1; i < numberOfBlocks; i++)
            {
                calculatedBCC ^= bitBlocks[i];
            }

            string calculatedBCCBinary = Convert.ToString(calculatedBCC, 2).PadLeft(bitLength, '0');

            // Check if the calculated BCC matches the input BCC
            if (calculatedBCC == inputBCC)
            {
                Console.WriteLine("\nNo errors detected.\n\n");
            }
            else
            {
                Console.WriteLine($"\nERROR!!.\nCalculated BCC: {calculatedBCCBinary}\n\n");
            }
        }
    }
}
