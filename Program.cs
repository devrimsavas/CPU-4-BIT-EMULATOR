using WinFormsApp1.Models;
namespace WinFormsApp1
{
    internal static class Program
    {
        public static Register Ax = new("Ax", [false,false,false,false]);
        public static Register Bx = new("Bx", [false,false,false,false]);
        public static Register SelectedRegister=new("Ax", [false,false,false,false]);
        //stack 
        public static Stack Stack = new("MainStack");
        //oppcde 
        public static OpCode oppCodeA = new( [false,false,false,false]);

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}