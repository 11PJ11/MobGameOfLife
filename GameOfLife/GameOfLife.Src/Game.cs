namespace GameOfLife.Src
{
    public class Game
    {
        private readonly Grid _grid;

        public Game(Grid grid)
        {
            _grid = grid;
        }

        public Grid Tick()
        {
            return _grid;
        }
    }
}