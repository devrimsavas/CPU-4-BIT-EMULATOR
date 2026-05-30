using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public static  class AluInputBuffer
    {
        public static bool[] TempA = new bool[4];
        public static bool[] TempB = new bool[4];
        public static bool[] OppCode= new bool[4];
        //Hardware enable pins 
        public static bool IsTempALoaded = false;
        public static bool IsTempBLoaded = false;
        public static bool IsOppCodeLoaded = false;

        public static void LoadTempA(bool[] regA)
        {
            TempA = (bool[])regA.Clone();
            IsTempALoaded = true;   
        }
        public static void LoadTempB(bool[] regB)
        {
            TempB = (bool[])regB.Clone();
            IsTempBLoaded = true;
        }
        public static void LoadOppCode(bool[] oppCode)
        {
            OppCode = (bool[])oppCode.Clone();
            IsOppCodeLoaded = true; 
        }
        public static void ClearBuffers()
        {
            for (int i = 0; i < 4; i++)
            {
                TempA[i] = false;
                TempB[i] = false;
                OppCode[i] = false;
            }
            IsTempALoaded = false;
            IsTempBLoaded = false;
            IsOppCodeLoaded = false;
        }
        public static bool[] Execute ()
        {
            // If Opcode is missing, default to 0000 (AND operation or safe ground)
            if (!IsOppCodeLoaded)
            {
                OppCode = new bool[] { false, false, false, false };
                IsOppCodeLoaded = true;
            }

            // If TempA is missing, default to 0000
            if (!IsTempALoaded)
            {
                TempA = new bool[] { false, false, false, false };
                IsTempALoaded = true;
            }

            // If TempB is missing, default to 0000
            if (!IsTempBLoaded)
            {
                TempB = new bool[] { false, false, false, false };
                IsTempBLoaded = true;
            }
            //ExTRA CHECK? may remove later: If TempA or TempB is missing, default to 0000 (safe ground)


            // Hardware safety check: Do not execute if data/command is missing
            if (!IsTempALoaded || !IsTempBLoaded || !IsOppCodeLoaded)
            {
                throw new InvalidOperationException("Hardware Error: Buffers or Opcode not fully loaded!");
            }

            // Opcode Decoding Logic
            if (OppCode.SequenceEqual(new bool[] { false, false, false, false })) // AND 0000
            {
                return Alu.AndOperation(TempA, TempB);
            }
            else if (OppCode.SequenceEqual(new bool[] { false, false, false, true })) // OR 0001
            {
                return Alu.OrOperation(TempA, TempB);
            }
            else if (OppCode.SequenceEqual(new bool[] { false, false, true, false })) // XOR 0010
            {
                return Alu.XorOperation(TempA, TempB);
            }
            else if (OppCode.SequenceEqual(new bool[] { false, false, true, true })) // NOT 0011
            {
                // Note: NOT only needs TempA, but hardware logic stays consistent
                return Alu.NotOperation(TempA);
            }
            else if (OppCode.SequenceEqual(new bool[] { false, true, false, false })) // ADD 0100
            {
                return Alu.AddOperation(TempA, TempB);
            }
            else if (OppCode.SequenceEqual(new bool[] { false, true, false, true })) // SUB 0101
            {
                return Alu.SubOperation(TempA, TempB);
            }
            else if (OppCode.SequenceEqual(new bool[] { true, false, false, false })) // SHIFT LEFT 1000
            {
                // Hardware behavior: TempB (Bx) is ignored for this operation
                return Alu.ShiftLeftOperation(TempA);
            }
            else if (OppCode.SequenceEqual(new bool[] { true, false, false, true })) // SHIFT RIGHT 1001
            {
                // Hardware behavior: TempB (Bx) is ignored for this operation
                return Alu.ShiftRightOperation(TempA);
            }
            else if (OppCode.SequenceEqual(new bool[] { true, false, true, false })) // INCREMENT A 1010
            {
                // Hardware behavior: TempB (Bx) is ignored for this operation
                return Alu.IncrementOperation(TempA);
            }
            else if (OppCode.SequenceEqual(new bool[] { true, false, true, true })) // DECREMENT A 1011
            {
                // Hardware behavior: TempB (Bx) is ignored for this operation
                return Alu.DecrementOperation(TempA);
            }
            else
            {
                throw new InvalidOperationException("Invalid operation code executed.");
            }


        }
    }
}
