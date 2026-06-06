using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Ram
    {
        // Connected display hardware instance
        private ComputerMonitor _screen;

        public Ram(ComputerMonitor screen)
        {
            _screen = screen;
        }

        // Intercept write requests for memory-mapped hardware (4-bit logic)
        public void Store(int address, bool[] data)
        {
            // Modular Screen Segment: Addresses 10 to 15 (0x0A to 0x0F)
            if (address >= 10 && address <= 15)
            {
                // Send the command directly to the monitor's command hub
                _screen.ProcessCommand(address, data);
            }
            else
            {
                // Normal memory: Addresses 0 to 9 (0x00 to 0x09)
                DataMemory.Write(address, data);
            }
        }

        // Standard memory read operation
        public bool[] Load(int address)
        {
            // Read from normal memory
            return DataMemory.Read(address);
        }
    }
}
