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
        
        

        public Matrix(List<List<int>> M)
        {
            matrix = M;

            
            
        }
        
        /*public int Determinant
        {
            get
            {
                return determinant;
            }
        }*/

        public List<int> this[int index]
        {
            get
            {
                return matrix[index];
            }
        }
        
        private Matrix PopRowAndCollum(int rowindex, int collumindex)
        {
            List<List<int>> temp = new List<List<int>>();
            for (int i = 0; i < matrix.Count; i++)
            {
                temp.Add(new List<int>(matrix[i]));
            }

            temp.RemoveAt(collumindex);

            for(int i = 0; i < temp.Count; i++)
            {
                int capacity = temp.Capacity;
                temp[i].RemoveAt(rowindex);
                capacity = temp.Capacity;

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


        public int Determ(Matrix m)
        {
            int Sin = 1;
            int det = 0;
            if (m.Length == 1)
            {
                return m[0][0];
            }
            for (int i = 0; i < m.Length; i++)
            {
                det +=  Sin * m[i][0] * Determ(m.PopRowAndCollum(0, i));
                Sin *= -1;
            }
            return det;
        }
    }
}
