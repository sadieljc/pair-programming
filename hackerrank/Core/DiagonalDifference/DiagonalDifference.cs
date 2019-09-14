using System;
using System.Collections.Generic;

namespace Core.DiagonalDifference
{
    public class DiagonalDifference
    {
        public int diagonalDifference(List<List<int>> matrix)
        {
            var firstDiagonal = 0;
            var secondDiagonal = 0;

            for (var i = 0; i < matrix.Count; i++)
            {
                firstDiagonal += matrix[i][i];
                secondDiagonal += matrix[i][matrix.Count - 1 - i];
            }

            return Math.Abs(firstDiagonal - secondDiagonal);
        }
    }
}