using System;

namespace Barcoma_Act10
{
    public class FunctionTwo
    {
        public void CalculateBCC()
        {
            Console.Write("Enter the number of blocks: ");
            int numBlocks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of bits: ");
            int bitLength = Convert.ToInt32(Console.ReadLine());

            int[] blocks = new int[numBlocks];

            for (int i = 0; i < numBlocks; i++)
            {
                Console.Write($"Enter block {i + 1}: ");
                string blockInput = Console.ReadLine();

                // Check if the block only consists of 1's and 0's
                foreach (char bit in blockInput)
                {
                    if (bit != '0' && bit != '1')
                    {
                        Console.WriteLine("\nInvalid input. Please enter a block (1's and 0's only).\n\n");
                        return;
                    }
                }

                // Check if the length of the block exceeds the bitLength
                if (blockInput.Length > bitLength)
                {
                    Console.WriteLine($"\nInvalid input. The length of the block exceeds the specified bit length of {bitLength}.\n\n");
                    return;
                }

                blocks[i] = Convert.ToInt32(blockInput, 2);
            }

            int bcc = blocks[0];
            for (int i = 1; i < numBlocks; i++)
            {
                bcc ^= blocks[i];
            }

            Console.WriteLine($"\nThe Block Check Character (BCC) is: {Convert.ToString(bcc, 2).PadLeft(bitLength, '0')}\n\n");
        }
    }
}
