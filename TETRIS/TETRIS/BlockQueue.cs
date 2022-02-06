using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TETRIS
{
    class BlockQueue
    {
        //une référence de tous les blocks que l'on a créé précédemment
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        //Permet de savoir quel sera le prochain bloc à s'afficher
        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }

        //Permet de choisir un block au hasard parmis la liste défini 
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }
        //Permet de récupérer les informations de notre bloc choisi au hasard
        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            }
            while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
