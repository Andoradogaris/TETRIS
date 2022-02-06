using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{

    class OBlock
    {
        private readonly Position[][] tiles = new Position[][]
        {
            //Comme ce block est carré, une rotation de celui-ci ne change rien sur la grille. Il sera affecté seulement par les changements de position.

            new Position[] { new(0,0), new(0,1), new(1,0), new(1,1) }
        };

        public override int Id => 4;
        protected override Position StartOffset => new Position(0, 4);
        protected override Position[][] Tiles => tiles;
    }
}
