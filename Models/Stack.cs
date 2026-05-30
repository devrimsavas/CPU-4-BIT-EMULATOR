using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Stack(string stackName)
    {
        public string StackName = stackName;
        public List<Register> StackList { get; set; } = [];

        public void AddRegister(Register register)
        {
            if (StackList.Count < 4)
                StackList.Add(register);
        }   
        public void ClearStack()
        {
            StackList.Clear();
        }
        public List<Register> DisplayStack()
        {
            return StackList;
        }
        public Register PopRegister ()
        {
            if (StackList.Count > 0)
            {
                var topRegister = StackList[StackList.Count - 1];
                StackList.RemoveAt(StackList.Count - 1);
                return topRegister;
            }
            else
            {
                return null!; 
            }
        }
    }
}
