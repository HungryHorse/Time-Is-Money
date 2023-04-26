using System;

namespace TIM.Core
{
    [Flags]
    public enum States
    {
        None = 0x0,
        Solid = 0x1,
        Liquid = 0x2,
        Gas = 0x4
    }
}
