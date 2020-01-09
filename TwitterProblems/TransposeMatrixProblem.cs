using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterProblems
{
/*
    Given a matrix, transpose it. 
    Transposing a matrix means the rows are now the column and vice-versa.

    Here's an example:

    def transpose(mat):
      # Fill this in.

    mat = [
        [1, 2, 3],
        [4, 5, 6],
    ]

    print(transpose(mat))
    # [[1, 4],
    #  [2, 5], 
    #  [3, 6]]
 */
    public class TransposeMatrixProblem
    {
        public List<List<int>> Solve(List<List<int>> matrix)
        {
            var result = new List<List<int>>();
            var columns = matrix.Count > 0 ? matrix[0].Count : 0;
            for (int i = 0; i < columns; i++)
            {
                var transponedColumn = new List<int>();
                foreach (var column in matrix)
                {
                    transponedColumn.Add(column[i]);
                }
                result.Add(transponedColumn);
            }
            return result;
        }
    }
}
