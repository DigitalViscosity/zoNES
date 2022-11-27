using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoNES.core.cpu
{
    internal class _6502
    {
        enum FLAGS6502
        {
            C = (1 << 0), // Carry Bit
            Z = (1 << 1), // Zero
            I = (1 << 2), // Disable Interrupts
            D = (1 << 3), // Decimal Mode unused
            B = (1 << 4), // Break
            U = (1 << 5), // Unused
            V = (1 << 6), // Overflow
            N = (1 << 7), // Negative
        }

        byte a      = 0x00, 
             x      = 0x00, 
             y      = 0x00, 
             stkp   = 0x00, 
             status = 0x00;

        ushort pc = 0x0000;

        Bus? bus;

        byte GetFlag(FLAGS6502 f)
        {
            return 0x00;
        }

        void SetFlag(FLAGS6502 f, bool v)
        {

        }
        Dictionary<ushort, string> disassemble(ushort nStart, ushort nStop)
        {
            return new Dictionary<ushort, string>();
        }

        public void Reset()
        {

        }

        public void Irq()
        {

        }

        public void Nmi()
        {

        }

        public void Clock()
        {

        }

        public bool Complete()
        {
            return false;
        }

        public void ConnectBus(Bus n)
        {
            bus = n;
        }
    }
}
