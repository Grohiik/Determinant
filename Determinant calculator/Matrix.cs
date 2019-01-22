using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinant
{
    class Matrix
    {
        List<List<int>> matrix = new List<List<int>>();
        int det = 0;
        int determinant;

        public Matrix(List<List<int>> M)
        {
            matrix = M;

            determinant = Determ(new Matrix(matrix));
            
        }
        
        public int Determinant
        {
            get
            {
                return determinant;
            }
        }

        public List<int> this[int index]
        {
            get
            {
                return matrix[index];
            }
        }
        
        private Matrix PopRowAndCollum(int rowindex, int collumindex)
        {
            List<List<int>> temp = matrix;
            temp.RemoveAt(collumindex);

            for(int i = 0; i < temp.Count; i++)
            {
                temp[i].RemoveAt(rowindex);
            }

            return new Matrix(temp);
        }
        public int Length
        {
            get
            {
                return matrix.Count;
            }
        }


        int Determ(Matrix m)
        {
            if (m.Length == 1)
            {
                return m[0][0];
            }
            for (int j = 0; j < m.Length; j++)
            {
                for (int i = 0; i < m.Length; i++)
                {
                    if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 2))
                    {
                        det += m[j][i] * Determ(m.PopRowAndCollum(j, i));
                    }
                    else
                    {
                        det -= m[j][i] * Determ(m.PopRowAndCollum(j, i));
                    }
                }
            }
            return det;
        }
    }
}
