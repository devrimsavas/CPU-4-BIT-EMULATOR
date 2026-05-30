using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static class Alu
    {
        public static bool[] AndOperation(bool[] regA, bool[] regB)
        {
            bool[] result = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = regA[i] && regB[i];
            }
            return result;
        }
        public static bool[] OrOperation(bool[] regA, bool[] regB)
        {
            bool[] result = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = regA[i] || regB[i];
            }
            return result;
        }
        public static bool[] XorOperation(bool[] regA, bool[] regB)
        {
            bool[] result = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = regA[i] ^ regB[i];
            }
            return result;
        }
        public static bool[] NotOperation(bool[] regA)
        {
            bool[] result = new bool[4];
            for (int i = 0; i < 4; i++)
            {
                result[i] = !regA[i];
            }
            return result;
        }

        public static bool[] AddOperation(bool[] regA, bool[] regB)
        {
            bool[] result = new bool[4];
            bool carry = false;
            for (int i = 3; i >= 0; i--)
            {
                bool sum = (regA[i] ^ regB[i]) ^ carry;
                carry = (regA[i] && regB[i]) || (carry && (regA[i] ^ regB[i]));
                result[i] = sum;
            }
            return result;
        }   

        public static bool[] SubOperation(bool[] regA, bool[] regB)
        {
            bool[] result = new bool[4];
            bool borrow = false;
            for (int i = 3; i >= 0; i--)
            {
                bool diff = (regA[i] ^ regB[i]) ^ borrow;
                borrow = (!regA[i] && regB[i]) || (borrow && (!regA[i] || regB[i]));
                result[i] = diff;
            }
            return result;
        }
        // Performs a 4-bit logical Shift Left operation (Multiply by 2)
        public static bool[] ShiftLeftOperation(bool[] regA)
        {
            bool[] result = new bool[4];
            result[0] = regA[1];
            result[1] = regA[2];
            result[2] = regA[3];
            result[3] = false; // Rightmost bit filled with 0
            return result;
        }
        // Performs a 4-bit logical Shift Right operation (Divide by 2)
        public static bool[] ShiftRightOperation(bool[] regA)
        {
            bool[] result = new bool[4];
            result[3] = regA[2];
            result[2] = regA[1];
            result[1] = regA[0];
            result[0] = false; // Leftmost bit filled with 0
            return result;
        }

        // Increments the register value by 1 using the existing AddOperation
        public static bool[] IncrementOperation(bool[] regA)
        {
            bool[] one = new bool[] { false, false, false, true }; // Binary 0001
            return AddOperation(regA, one);
        }

        // Decrements the register value by 1 using the existing SubOperation
        public static bool[] DecrementOperation(bool[] regA)
        {
            bool[] one = new bool[] { false, false, false, true }; // Binary 0001
            return SubOperation(regA, one);
        }






    }
}