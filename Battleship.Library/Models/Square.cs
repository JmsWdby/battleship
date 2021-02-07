using System;
using Battleship.Library.Enums;

namespace Battleship.Library.Models
{
    public class Square
    {
        public Square(string y, int x)
        {
            Y = y;
            X = x.ToString();

            LastUpdated = DateTime.UtcNow;
        }
        
        public string Y { get; }
        public string X { get; }
        public string Coordinates => Y + X;
        public SquareStatus? Status { get; private set; }
        public DateTime LastUpdated { get; private set; }

        public void UpdateStatus(SquareStatus status)
        {
            if (Status == status)
            {
                return;
            }

            Status = status;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
