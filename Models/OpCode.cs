using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class OpCode
    {
        
        public bool[] Bits { get; set; }=new bool[4];
        public OpCode() 
        {
            Clear();
            

        }
        //opp code from existing array set 
        public OpCode (bool[] sourceBits)
        {
            SetBits(sourceBits);

        }
        public void SetBits(bool[] sourceBits)
        {
            if (sourceBits==null || sourceBits.Length != 4)
            {
                throw new ArgumentException("Opcode must be an array of 4 bits.");
            }   
            Bits = (bool[])sourceBits.Clone();  
        }
        public void Clear()
        {
            for (int i = 0; i < Bits.Length; i++)
            {
                Bits[i] = false;
            }
        }   
    }
}
