namespace Barcoma_Act10
{
    public class FunctionFour
    {
        public void CalculateParity()
        {
            Console.Write("Enter the number of blocks: ");
            int numberOfBlocks = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the bits: ");
            int bitLength = int.Parse(Console.ReadLine());

            int[] bitBlocks = new int[numberOfBlocks];
            for (int i = 0; i < numberOfBlocks; i++)
            {
                while (true)
                {
                    Console.Write($"Enter block {i + 1}: ");
                    string input = Console.ReadLine();
                    if (input.Length > bitLength)
                    {
                        Console.WriteLine($"\nInput length exceeds the limit of {bitLength}. Stopping the function.\n\n");
                        return;
                    }
                    if (input.All(c => c == '0' || c == '1'))
                    {
                        bitBlocks[i] = Convert.ToInt32(input, 2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter a binary number (0 and 1 only).\n\n");
                    }
                }
            }

            Console.Write("Enter the parity type (even/odd): ");
            string parityType = Console.ReadLine();

            // Calculate BCC
            int bcc = bitBlocks[0];
            for (int i = 1; i < numberOfBlocks; i++)
            {
                bcc ^= bitBlocks[i];
            }

            // Calculate parity bits and BCC parity bit
            string parityBits = "";
            int bccParityBitCount = 0;
            foreach (int block in bitBlocks)
            {
                int bitCount = CountBits(block);
                parityBits += (parityType == "even" ? bitCount % 2 == 0 : bitCount % 2 != 0) ? "0" : "1";
                bccParityBitCount += bitCount;
            }
            string bccParityBit = (parityType == "even" ? bccParityBitCount % 2 == 0 : bccParityBitCount % 2 != 0) ? "0" : "1";

            Console.WriteLine($"\nBCC: {Convert.ToString(bcc, 2)}, Parity Bits: {parityBits}, BCC Parity Bit: {bccParityBit}\n\n");
        }

        private int CountBits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count += number & 1;
                number >>= 1;
            }
            return count;
        }
    }
}
