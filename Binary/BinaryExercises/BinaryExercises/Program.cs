using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryExercises
{
    class Program
    {
        const byte CHAINSAW = 0x01;
        const byte PISTOL = 0x01 << 1;
        const byte SHOTGUN = 0x01 << 2;
        const byte SUPER_SHOTGUN = 0x01 << 3;
        const byte CHAINGUN = 0x01 << 4;
        const byte ROCKET_LAUNCHER = 0x01 << 5;
        const byte PLASMA_GUN = 0x01 << 6;
        const byte BFG9000 = 0x01 << 7;

        public static readonly string[] weapons = {
         "Fists", "Chainsaw", "Pistol", "Shotgun", "Super Shotgun", "Chaingun",
        "Rocket Launcher", "Plasma Gun", "BFG 9000"
         };


        static void Main(string[] args)
        {
            /*
            4056 2048 1024 512 256 128 64 32 16 8 4 2 1
            1. Convert the following from decimal to binary 
            • 1 
                8 4 2 1
                0 0 0 1
            • 42       
                32 16 8 4 2 1
                1  0  1 0 1 0
                101010
            42 / 32 1
            10 /7   0
            10/8    1
            2/4     0
            2/2     1
                    0

            • 256 
                256 128 64 32 16 8 4 2 1
                1   0   0  0  0  0 0 0 0
            • 4,294,967,296 
 ??             1 0000 0000 0000 0000 0000 0000 0000 0000‬

            2. Convert the following from binary to decimal 
            • 10000000 
            128 64 32 16 8 4 2 1
            1   0  0  0  0 0 0 0
            128
            • 10101010 
            128 64 32 16 8 4 2 1
            1   0  1  0  1 0 1 0
            128+32+8+2
            170
            • 11110000 
            128 64 32 16 8 4 2 1
            1   1  1  1  0 0 0 0
            128 + 64 +32 +16
            = 240
            • 11001100 
            128 64 32 16 8 4 2 1
            1   1  0  0  1 1 0 0
            128+64+8+4
            = 204
            3. Solve these binary arithmetic problems 
            • 111 + 111 
            1110
            14

            • 1010 + 1010 
            1010
            1010
            10100
            16 +4 
            22

            • 11101 + 1010 
            11101
             1010
           100111
            • 1101 - 11 
                1010
            • 10001 - 100 
            10001
              100
             1101

            • 101 x 10 
            • 1011 x 11 
            • 1101 / 11 
 
            ieee714

            4. In many places, numbers stored in computers are displayed as hexadecimal (base 16). 
            What advantages do hex numbers have over decimal and binary numbers respectively when displaying numbers stored in a computer? 
 
            5. Using Two's complement convert the following between decimal and binary (for binary use 1 signed byte) 
            • 10000000
              01111111
                     1
              10000000 

            • 10101010 
              01010101
                     1
              01010111
              57
            • 11110000 
            • 11001100 
            • -16 
            16 8 4 2 1
            
            • 128 
            128  64 32 16 8 4 2 1
            1    0  0  0  0 0 0 0  
            64 32 16 8
            • -128 
            128  64 32 16 8 4 2 1
            1    0  0  0  0 0 0 0 
            • -123 
            
            6. What do each of these evaluate to? 
            • 11111 | 11111     
            11111
            11111
            11111
            • 11111 ^ 11111
            00000
            • 10101 & 11111 
            10101
            11111
            10101
            • 10101 | 11111     
            10101 
            11111
            11111
            • 00000 ^ 11111 
            11111
            • 1   << 3 
            0001
            1000
            • 100  >> 2   
            1100100
              11001
            • ~10101 
            10101
            01010
            • 100 << 1  
            1100100
           11001000 
            • 1010 >> 1    
            1010
            0101
            • ~11111 
            11111
            00000
 
            7. A true/false value can be stored in a single bit – zero for false, one for true. However, the Boolean type in C is a full byte big – 8 bits. 
            This means it is possible to store 8 bits in a single byte. Using bitwise operators, how might you 
            • Set an single bit to 0 
            • Set an single bit to 1 
            &
            • Check the value of a single bit 
 
 
            8. Implement the following functions in C#  
            • bool IsLeftMostBitSet(uint value) 
                • Returns true if the left most (the most significant) bit of value is set and false otherwise 
            • bool IsRightMostBitSet(uint value) 
                 • Returns true if the right most (the least significant) bit of value is set and false otherwise 
            • bool IsBitSet(uint value, unsigned char bit_to_check) 
                • Returns true if the asked for bit is set, and false otherwise. 
                bit_to_check is zero indexed from the right most bit. i.e 0 is the right most bit and 31 is the left most. 
            • int GetRightMostSetBit(uint value) • This function returns the index of the right most bit set to 1 in value 
                • If no bits are set, it returns -1 
                • For example 
                    o 00000001 would return 0 
                    o 10011100 would return 2 
                    o 01010000 would return 4 
                    o 00000000 would return -1 
            • void PrintBinary(unsigned byte value) 
                • Prints value to the console as a binary number 
            • CHALLENGE: bool IsPowerOf2(uint value) 
                • Returns true of value is a power of 2 and false otherwise. Use only bitwise and arithmetic operators. 
             
             */
            byte red = 255;
            byte green = 200;
            byte blue = 150;
            byte alpha = 2;

            Colour colour = new Colour();
            colour.SetRed(red);
            colour.SetGreen(green);
            colour.SetBlue(blue);
            colour.SetAlpha(alpha);

            Console.WriteLine("Set Red too " + red + ". Retreived: " + colour.GetRed());
            Console.WriteLine("Set Green too " + green + ". Retreived: " + colour.GetGreen());
            Console.WriteLine("Set Blue too " + blue + ". Retreived: " + colour.GetBlue());
            Console.WriteLine("Set Alpha too " + alpha + ". Retreived: " + colour.GetAlpha());


            colour.SetBlue(red);
            Console.WriteLine("Set Red too " + red + ". Retreived: " + colour.GetRed());
            Console.WriteLine("Set Green too " + green + ". Retreived: " + colour.GetGreen());
            Console.WriteLine("Set Blue too " + blue + ". Retreived: " + colour.GetBlue());
            Console.WriteLine("Set Alpha too " + alpha + ". Retreived: " + colour.GetAlpha());
            Console.ReadKey();


            byte inventory = 0;
            inventory |= PLASMA_GUN;
            inventory |= PISTOL;
            inventory |= CHAINSAW;
            PrintInventory(inventory);
            Console.ReadKey();

             byte value = 202;
            ByteClass newByte = new ByteClass(value);
            newByte.PrintBinary(value);
            Console.WriteLine("IsLeftMostBitSet: " + newByte.IsLeftMostBitSet(value));
            Console.WriteLine("IsRightMostBitSet: " + newByte.IsRightMostBitSet(value));
            Console.WriteLine("GetRightMostSetBit: " + newByte.GetRightMostSetBit(value));

            Console.ReadKey();

        }

        /* public static void PrintInventory(byte inventory)
         {
             Console.Write("Fists | ");
             if ((inventory & CHAINSAW) == CHAINSAW)
                 Console.Write("Chainsaw | ");
             if ((inventory & PISTOL) == PISTOL)
                 Console.Write("Pistol | ");
             if ((inventory & SHOTGUN) == SHOTGUN)
                 Console.Write("Shotgun | ");
             if ((inventory & SUPER_SHOTGUN) == SUPER_SHOTGUN)
                 Console.Write("Super Shotgun | ");
             if ((inventory & CHAINGUN) == CHAINGUN)
                 Console.Write("Chaingun | ");
             if ((inventory & ROCKET_LAUNCHER) == ROCKET_LAUNCHER)
                 Console.Write("Rocket Launcher | ");
             if ((inventory & PLASMA_GUN) == PLASMA_GUN)
                 Console.Write("Plasma Gun | ");
             if ((inventory & BFG9000) == BFG9000)
                 Console.Write("BFG 9000 | ");
             Console.Write("\n");
         }*/

        public static void PrintInventory(byte inventory)
        {
            Console.Write("{0} | ", weapons[0]);
            for (int i = 1; i < weapons.Length; i++)
            {
                int mask = 0x01 << i - 1;
                if ((inventory & mask) == mask)
                {
                    Console.Write("{0} | ", weapons[i]);
                }
            }
            Console.Write("\n");
        }
        public static void AddToInventory(ref byte inventory, byte weapon)
        {
            inventory |= weapon;
        }
    }
}
