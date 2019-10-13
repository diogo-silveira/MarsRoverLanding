using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Interfaces;
using MarsRoverLandingService.Manager;

namespace MarsRoverLandingService.Services
{
    public class PositionService : Position, IPositionService
    {
        private List<IMove> _movesList;
        public PositionService() : base() { }

        public void StartMoving(List<int> maxPoints, string moves)
        {
          _movesList = new List<IMove>();

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        _movesList.Add(new MoveInSameDirection());
                        break;
                    case 'L':
                        _movesList.Add(new Rotate90Left());
                        break;
                    case 'R':
                        _movesList.Add(new Rotate90Right());
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (this.X < 0 || this.X > maxPoints[0] || this.Y < 0 || this.Y > maxPoints[1])
                {
                    throw new Exception($"Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
            StartMoving(_movesList);
        }

        
    }
}
