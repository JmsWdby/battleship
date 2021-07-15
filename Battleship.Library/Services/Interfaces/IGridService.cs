using System.Collections.Generic;
using Battleship.Library.Enums;
using Battleship.Library.Models;

namespace Battleship.Library.Services.Interfaces
{
    public interface IGridService
    {
        Grid Create();
        Grid Create(int width, int height);
        void SetShipPosition(Grid grid, Ship ship);
        void SetShipPosition(Grid grid, Ship ship, string position, Heading heading);
        IEnumerable<string> GetShipPositions(Grid grid);
        IEnumerable<string> GetValidTargets(Grid grid);
        IEnumerable<string> GetValidNeighbouringTargets(Grid grid, string position);
        ShipType? Attack(Grid grid, string target);
        bool HasShipBeenSunk(Grid grid, ShipType shipType);
    }
}