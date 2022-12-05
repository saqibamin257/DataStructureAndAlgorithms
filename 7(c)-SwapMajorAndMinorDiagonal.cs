using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class SwapMajorAndMinorDiagonal
    {
        public void SwapDiagonals()
        {
            int[,] matrix = {
                          { 1,2,3},
                          { 4,5,6},
                          { 7,8,9} };

            //output
            //3,2,1
            //4,5,6
            //9,8,7


            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int length = matrix.GetLength(1) - 1;

            Console.WriteLine("---Original matrix---\n");
            PrintMatrix(matrix);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                    {
                        int temp = matrix[i, j];
                        int r = length - i;                        
                        matrix[i, j] = matrix[i,r];
                        matrix[i,r] = temp;
                    }
                }
            }
            Console.WriteLine("---Swap Minor Diagonals with Major---\n");
            PrintMatrix(matrix);
        }
        public void PrintMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
