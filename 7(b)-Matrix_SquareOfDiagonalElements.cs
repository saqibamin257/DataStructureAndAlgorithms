using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class Matrix_SquareOfDiagonalElements_Result
    {
        /*1 2 3
         4 5 6
        7 8 9*/
        //Diagonal elements are a11 a22 a33 where row and col are same
        // 1 5 9  are diagonal elements
        // 1 25 81 are square of diagonal elements 

        public void SquareOfDiagonals(int[,] matrix) 
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            List<int> result = new List<int>();

            Console.WriteLine("\n---Diagonal elements are ---");
            for (int i=0; i<row; i++) 
            {
                for(int j=0; j<col; j++) 
                {
                    if (i == j) 
                    {
                        Console.Write($"{matrix[i, j]} ");
                        result.Add(matrix[i,j]);
                    }
                }
            }

            Console.WriteLine("\n---Square of Diagonals are ---");
            PrintSquare(result);
        }

        public void PrintSquare(List<int> list) 
        {
            for(int i=0; i<list.Count; i++) 
            {
                int square = list[i] * list[i];
                Console.Write($"{square} ");
            }            
        }
    }
    internal class Matrix_SquareOfDiagonalElements_Solution 
    {
        public void Input() 
        {
            int[,] matrix = { {1,2,3},
                              {4,5,6 },
                              {7,8,9 }};

            //output Diagonal elements are 1 5 9
            //square of Diagonals are      1 25 81
            new Matrix_SquareOfDiagonalElements_Result().SquareOfDiagonals(matrix);


        }
    }
}
