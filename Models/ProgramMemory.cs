using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1.Models
{
    public static class ProgramMemory
    {
        public static List<string> MemoryList = [];
        //clear 
        public static void ClearMemory()
        {
            MemoryList.Clear();
        }
        //push to memory
        public static void PushToMemory(string binaryInstruction,int overFlowLimit)
        {
            if (MemoryList.Count < overFlowLimit) // Arbitrary limit to prevent overflow
                MemoryList.Add(binaryInstruction);
        }  
        public static void SaveToFile(string filePath)
        {
            File.WriteAllLines(filePath, MemoryList);
        }
         public static void LoadFromFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                MemoryList = File.ReadAllLines(filePath).ToList();
            }
        }   
    }
}
