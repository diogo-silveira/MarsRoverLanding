using MarsRoverLandingService.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLandingService.Interfaces
{
    public interface IMove
    {
        void Next(ref int X, ref int Y, ref Directions directions);
    }
}
