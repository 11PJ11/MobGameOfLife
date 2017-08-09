namespace GameOfLife.Src
{
    public class Grid
    {
        public static Grid WithLiveCell(Cell liveCell)
        {
            return new Grid(liveCell);
        }

        public static Grid Empty()
        {
            return new Grid();
        }

        private Cell _liveCell;

        private Grid()
        {
        }

        private Grid(Cell liveCell)
        {
            _liveCell = liveCell;
        }

        public override string ToString()
        {
            return $"{GetType().FullName} {nameof(_liveCell)}: {_liveCell}";
        }

        protected bool Equals(Grid other)
        {
            return Equals(_liveCell, other._liveCell);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Grid) obj);
        }

        public override int GetHashCode()
        {
            return (_liveCell != null ? _liveCell.GetHashCode() : 0);
        }
    }
}