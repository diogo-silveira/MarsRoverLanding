using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverLandingService.Interfaces
{
    public interface IPositionService
    {
        void StartMoving(List<int> maxPoints, string moves);
    }
}
