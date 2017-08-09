using NUnit.Framework;

namespace GameOfLife.Test
{
    using FluentAssertions;
    using Src;

    [TestFixture]
    public class GameShould
    {
        [Test] public void 
        GenerateEmptyGrid_WhenTicking_GivenAnEmptySeed()
        {
            Grid emptyGrid = Grid.Empty();
            Game game = new Game(emptyGrid);

            Grid nextGeneration = game.Tick();

            nextGeneration.Should().Be(Grid.Empty());
        }

        [Test] public void 
        GenerateEmptyGrid_WhenTicking_GivenGridWithOneCell()
        {
            Cell cell = new Cell();
            Grid gridWithOneLiveCell = Grid.WithLiveCell(cell);

            Game game = new Game(gridWithOneLiveCell);

            Grid nextGeneration = game.Tick();

            nextGeneration.Should().Be(Grid.Empty());
        }

    }
}