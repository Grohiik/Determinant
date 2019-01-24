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

            tbxdeterminant.Text = matris.Determ(matris).ToString();
        }

        List<List<int>> Matrixmaking()
        {
            string[] tempstring;

            tempstring = tbxmatris.Text.Split(new[] { "\r\n", "\r", "\n" },StringSplitOptions.None);

            int[][] tempmatrix = new int[tempstring.Length][];

            for (int i = 0; i < tempstring.Length; i++)
            {
                string[] temp = tempstring[i].Split(' ');
                for (int j = 0; j < tempstring.Length; j++)
                {
                    if (i == 0) tempmatrix[j] = new int[tempstring.Length];
                    tempmatrix[j][i] = (int.Parse(temp[j]));
                }
            }
            List<List<int>> listList = new List<List<int>>();
            for(int i = 0; i < tempmatrix.Length; i++)
            {
                listList.Add(tempmatrix[i].ToList());
            }
            return listList;
        }
    }
}
