using Battleship.Library.Models;
using Battleship.Library.Services.Implementations;
using Xunit;

namespace Battleship.Test
{
    public class GridServiceTests
    {
        [Fact]
        public void Create_ReturnsStandardGrid()
        {
            // Arrange
            var gridService = new GridService();

            // Act
            Grid grid = gridService.Create();

            // Assert
            Assert.Equal(100, grid.Squares.Count);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(-1, -1, 0)]
        [InlineData(-1, 1, 0)]
        public void Create_ReturnsGrid(int width, int height, int squareCount)
        {
            // Arrange
            var gridService = new GridService();

            // Act
            Grid grid = gridService.Create(width, height);

            // Assert
            Assert.Equal(squareCount, grid.Squares.Count);
        }
    }
}
