using System;
using System.Linq;
using MarsRoverLandingService.Enums;
using MarsRoverLandingService.Services;

namespace MarsRoverLanding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter one space between each value.");
            Console.Write("Plateau: ");
            var maxPoints = Console.ReadLine()?.Trim().Split(' ').Select(int.Parse).ToList();
            Console.Write("Position and Location: ");
            var startPositions = Console.ReadLine()?.Trim().Split(' ');

            PositionService positionService = new PositionService();

            if (startPositions.Count() == 3)
            {
                positionService.X = Convert.ToInt32(startPositions[0]);
                positionService.Y = Convert.ToInt32(startPositions[1]);
                positionService.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
            }
            Console.Write("Movements: ");
            var moves = Console.ReadLine()?.ToUpper();

            try
            {
                positionService.StartMoving(maxPoints, moves);
                Console.WriteLine($"{positionService.X} {positionService.Y} {positionService.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
