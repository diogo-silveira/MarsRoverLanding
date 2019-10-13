using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Interfaces;

namespace MarsRoverLandingService.Manager
{
    public abstract class Position : IPosition
    {
        public int X, Y = 0;
        public Directions Direction = Directions.N;

        protected Position()
        {
        }

        protected void StartMoving(List<IMove> moves)
        {
            foreach (IMove move in moves)
            {
              move.Next(ref X, ref Y, ref Direction);
            }
        }

    }
}
