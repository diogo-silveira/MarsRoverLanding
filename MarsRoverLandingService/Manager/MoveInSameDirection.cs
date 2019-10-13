using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLandingService.Manager
{
   public partial class MoveInSameDirection : IMove
    {
        public virtual void Next(ref int X,ref int Y, ref Directions direction)
        {
            switch (direction)
            {
                case Directions.N:
                    Y += 1;
                    break;
                case Directions.S:
                    Y -= 1;
                    break;
                case Directions.E:
                    X += 1;
                    break;
                case Directions.W:
                    X -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
