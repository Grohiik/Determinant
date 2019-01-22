using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Determinant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnberäkna_Click(object sender, EventArgs e)
        {
            Matrix matris = new Matrix(Matrixmaking());

            tbxdeterminant.Text = matris.Determinant.ToString();
        }

        List<List<int>> Matrixmaking()
        {
            string[] tempstring;
            
            tempstring = tbxmatris.Text.Split(Environment.NewLine.ToCharArray());

            List<int>[] tempmatrix = new List<int>[tempstring.Length];

            for (int i = 0; i < tempstring.Length; i++)
            {
                string[] temp = tempstring[i].Split(' ');
                for (int j = 0; j < tempstring.Length; j++)
                {
                    tempmatrix[i][j] = int.Parse(temp[j]);
                }
            }
            
            return tempmatrix.ToList();
        }
    }
}
