using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using zoNES.core.cpu;

namespace zoNES.core
{
    internal class Bus
    {
        byte[] ram = new byte[64 * 1024];
        _6502 cpu = new();

        public Bus()
        {
            cpu.ConnectBus(this);

            for (int i = 0; i < ram.Length; i++)
            {
                i = 0x00;
            }
        }
        public byte Read(ushort address, bool bReadOnly = false)
        {
            if(address >= 0x0000 && address <= 0xFFFF)
                return ram[address];
            
            return 0x00;
        }

        public void Write(ushort address, byte data)
        {
            if(address >= 0x0000 && address <= 0xFFFF)
                ram[address] = data;
        }

    }
}
