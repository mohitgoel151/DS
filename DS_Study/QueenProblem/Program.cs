
namespace QueenProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] chessboard = new int[8, 8]
            {
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0}
            };

            ArrangeQueen aQueen = new ArrangeQueen(chessboard);

        }
    }
}
