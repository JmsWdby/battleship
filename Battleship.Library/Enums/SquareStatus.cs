using System;

namespace Battleship.Library.Enums
{
    [Flags]
    public enum SquareStatus
    {
        AircraftCarrier = 1,
        Battleship = 2,
        Cruiser = 4,
        Submarine = 8,
        Destroyer = 16,
        Hit = 32,

        Ship = AircraftCarrier | Battleship | Cruiser | Submarine | Destroyer
    }
}
