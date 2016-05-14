﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] maze = new int[10, 11]
            {

                { 1, 6, 5, 2, 1, 1, 2, 3, 2, 1, 4  },
                { 1, 2, 6, 3, 2, 1, 1, 3, 4, 5, 6  },
                { 1, 2, 3, 2, 1, 3, 2, 5, 6, 4, 2  },
                { 2, 3, 1, 2, 2, 3, 3, 4, 5, 2, 1  },
                { 3, 4, 2, 3, 4, 5, 3, 2, 1, 4, 2  },
                { 4, 3, 4, 4, 5, 6, 4, 3, 2, 5, 3  },
                { 5, 4, 2, 1, 2, 3, 4, 4, 3, 6, 4  },
                { 6, 5, 3, 2, 3, 4, 5, 5, 4, 1, 1  },
                { 1, 6, 4, 3, 5, 5, 6, 6, 1, 2, 3  },
                { 2, 1, 5, 1, 6, 6, 1, 2, 2, 3, 4  }
            };


            //int[,] maze = new int[4, 3]
            //{

            //    { 1, 1, 2  },
            //    { 1, 2, 1  },
            //    { 2, 1, 2  },
            //    { 1, 2, 3  }
            //};


            Maze aMaze = new Maze(maze);

        }
    }
}
