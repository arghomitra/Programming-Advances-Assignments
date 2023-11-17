using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Magic
{
    class MagicSquare
    {
        public int[,] Square { get; set; }
        private int size;
        

        public MagicSquare(int square_size)
        {
            size = square_size;
            Square = new int[size,size];

        }

        public void Create(int row, int col, int placed)
        {
            
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Square[i, j] = '_';
                }


            }
        }

    }
}
