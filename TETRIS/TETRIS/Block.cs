using System.Collections.Generic;

namespace TETRIS
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Position offset;

        //Permet d'appliquer notre offset(décalage) à notre block pour le centrer sur la grille
        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        //Tourne le bloc dans le sens des aiguilles d'une montre
        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        //Tourne le bloc dans le sens inverse des aiguilles d'une montre
        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        //Applique une translation sur le bloc
        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        //Remet les informations de déplacement du bloc à 0
        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}
