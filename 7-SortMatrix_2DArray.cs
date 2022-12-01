using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    internal class SortMatrix_Result
    {
        public int[,] sortMatrix(int[,] mat) 
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            // temporary matrix of size n^2
            int[] temp = new int[rows * cols];
            int k = 0;
            
            // copy the elements of matrix
            // one by one into temp[]
            for(int i = 0; i < rows; i++) 
            {
                for(int j=0; j < cols; j++) 
                {
                    temp[k] = mat[i, j];
                    k++;
                }
            }
            ///sort temp []
            Array.Sort(temp);

            // copy the elements of temp[]
            // one by one in mat[][]
            int count = 0;
            for(int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < cols; j++) 
                {
                    mat[i, j] = temp[count];
                    count++;
                }
            }
            return mat;
        }
        public void PrintMatrix(int[,] matrix) 
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < cols; j++) 
                {
                    Console.Write($"{matrix[i,j]} ");
                }
            }
        }
    }    
    internal class SortMatrix_Solution 
    {
        public void Input() 
        {
            //CASE-1

            //int[,] matrix = {
            //    {5,4,7 },
            //    {1,3,8},
            //    {2,9,6}};

            //CASE-2
            int[,] matrix = { {10,4,6,8 },
                              {12,16,14,18 },
                              {2,22,24,20 } };



            Console.WriteLine("\nOriginal Matrix");

            new SortMatrix_Result().PrintMatrix(matrix);           

            Console.WriteLine("\nSorted Matrix");            
            int[,] mat = new SortMatrix_Result().sortMatrix(matrix);

            //Print Matrix elements
            new SortMatrix_Result().PrintMatrix(mat);
        }
    }
}
