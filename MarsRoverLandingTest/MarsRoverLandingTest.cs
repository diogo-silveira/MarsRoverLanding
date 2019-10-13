using System;
using System.Collections.Generic;
using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Manager;
using MarsRoverLandingService.Services;
using Xunit;

namespace MarsRoverLandingTest
{
    public class MarsRoverLandingTest
    {
        private PositionService _positionService;

        [Fact]
        public void TestScenario_WhenDirectionIs12N_andMovesLMLMLMLMM()
        {
            _positionService = new PositionService
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            _positionService.StartMoving(maxPoints, moves);

            var actualOutput = $"{_positionService.X} {_positionService.Y} {_positionService.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.Matches(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestScenario_WhenDirectionIs33E_and_MovesMMRMMRMRRM()
        {
            _positionService = new PositionService
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            _positionService.StartMoving(maxPoints, moves);

            var actualOutput = $"{_positionService.X} {_positionService.Y} {_positionService.Direction.ToString()}";
            var expectedOutput = "5 1 E";

            Assert.Matches(expectedOutput, actualOutput);
        }


        [Theory]
        [InlineData(3, 1, "E", "MRRMMRMRRM")]
        [InlineData(1, 3, "N", "MRRMMRRM")]
        [InlineData(3, 2, "W", "MRRMIRMRRM")]
        public void TestScenario_WhenDirectionsAndMovesFail(int x, int y, string direction, string move)
        {
            _positionService = new PositionService
            {
                X = x,
                Y = y,
                Direction = Enum.Parse<Directions>(direction)
            };

            var maxPoints = new List<int>(){ 5 , 5};
            var moves = move;

            _positionService.StartMoving(maxPoints, moves);

            var actualOutput = $"{_positionService.X} {_positionService.Y} {_positionService.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.DoesNotMatch(expectedOutput, actualOutput);
        }

    }
}
