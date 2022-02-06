namespace TETRIS
{
    /*
     Toutes les classes "xBlock" sont presque identique.
     Elles permettent de définir les informations de chaque blocks présent dans le jeu
     */




    //Défini Le Block qui ressemble à un I 
    public class IBlock : Block
    {
        //Permet de recenser les rotations possibles pour le bloc
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[] { new(1,0), new(1,1), new(1,2), new(1,3) },
            new Position[] { new(0,2), new(1,2), new(2,2), new(3,2) },
            new Position[] { new(2,0), new(2,1), new(2,2), new(2,3) },
            new Position[] { new(0,1), new(1,1), new(2,1), new(3,1) }
        };

        //On donne un ID à notre bloc afin de pouvoir y accéder plus facilement
        public override int Id => 1;
        //Start Offset permet de faire apparaître notre bloc au milieu de notre grille de jeu
        protected override Position StartOffset => new Position(-1, 3);
        protected override Position[][] Tiles => tiles;
    }
}