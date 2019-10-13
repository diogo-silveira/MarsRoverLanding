using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLandingService.Manager
{
   public partial class Rotate90Left : IMove
    {
        public virtual void Next(ref int X, ref int Y, ref Directions direction)
        {
            switch (direction)
            {
                case Directions.N:
                    direction = Directions.W;
                    break;
                case Directions.S:
                    direction = Directions.E;
                    break;
                case Directions.E:
                    direction = Directions.N;
                    break;
                case Directions.W:
                    direction = Directions.S;
                    break;
                default:
                    break;

            }
        }
    }
}
