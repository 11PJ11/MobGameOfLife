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
            Grid emptyGrid = new Grid();
            Game game = new Game(emptyGrid);

            Grid nextGeneration = game.Tick();

            nextGeneration.Should().Be(emptyGrid);
        }

        [Test] public void 
        GenerateEmptyGrid_WhenTicking_GivenGridWithOneCell()
        {
            
        }

    }
}