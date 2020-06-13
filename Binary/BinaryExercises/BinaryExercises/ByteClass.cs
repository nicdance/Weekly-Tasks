using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryExercises
{
    class ByteClass
    {
        public byte value;
        public ByteClass()
        {
        }
        public ByteClass(Byte newByte)
        {
            value = newByte;
        }

        public bool IsLeftMostBitSet(uint value)
        {
            //Returns true if the left most(the most significant) bit of value is set and false otherwise 
            //.Console.WriteLine(value);
            //Console.WriteLine(Convert.ToString(value, 2));
            int checkBit = 1;
            while (checkBit <= value)
            {
            //    Console.WriteLine(Convert.ToString(checkBit, 2));
            //    Console.WriteLine(checkBit);
                if (checkBit*2> value)
                {
                    break;
                }
                checkBit = checkBit * 2;

            //    Console.WriteLine(Convert.ToString(checkBit, 2));
            //    Console.WriteLine(checkBit);
            }

            bool bitSet = IsBitSet(value, (char)checkBit);
         //   Console.WriteLine(Convert.ToString(value, 2));
         //   Console.WriteLine(Convert.ToString(checkBit, 2));
//            Console.WriteLine(bitSet);

            return bitSet;
        }

        public bool IsRightMostBitSet(uint value)
        {
            //Returns true if the right most(the least significant) bit of value is set and false otherwise
            int checkBit = 1;
            bool bitSet = IsBitSet(value, (char)checkBit);
           //// Console.WriteLine(Convert.ToString(value, 2));
           // Console.WriteLine(Convert.ToString(checkBit, 2));
          //  Console.WriteLine(bitSet);
            return bitSet;
        }

        public bool IsBitSet(uint value, char bit_to_check)
        {
            //    • Returns true if the asked for bit is set, and false otherwise.
            //    bit_to_check is zero indexed from the right most bit.i.e 0 is the right most bit and 31 is the left most.

            return (value & bit_to_check) == bit_to_check;
        }

        public int GetRightMostSetBit(uint value) {
            //• This function returns the index of the right most bit set to 1 in value 
            //    • If no bits are set, it returns -1 
            //    • For example
            //        o 00000001 would return 0 
            //        o 10011100 would return 2 
            //        o 01010000 would return 4 
            //        o 00000000 would return -1

            int checkBit = 1;
            int position = -1;
            bool oneFound = false;
            while (checkBit <= value)
            {
                position++;

                oneFound = IsBitSet(value, (char)checkBit);
                //Console.WriteLine(Convert.ToString(checkBit, 2));
                if (oneFound == true)
                {
                    break;
                }
                checkBit = checkBit * 2;
            }
            if (oneFound == false)
            {
                position = -1;
            }

            return position;
        }

        public void PrintBinary(byte value) {
            //    • Prints value to the console as a binary number 
            Console.WriteLine(value);//Convert.ToString(value,2));
            Console.WriteLine(Convert.ToString(value,2));
        }
        public bool IsPowerOf2(uint value) {
            //    • Returns true of value is a power of 2 and false otherwise.Use only bitwise and arithmetic operators.
            return true;
        }
    }
}
