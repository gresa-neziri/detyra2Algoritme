using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detyra2BruteForce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Numri i vargjeve = " + Numero(matrica1, 27, 3));

        }
        public int[,] matrica1 = { {1,1,1 },
                                  {1,1,2 },
                                  {1,1,3 },
                                  {1,2,1 }
                                , {1,2,2 }
                                , {1,2,3 }
                                , {1,3,1 }
                                , {1,3,2 }
                                , {1,3,3 }
                                , {2,1,1 }
                                , {2,1,2 }
                                , {2,1,3 }
                                , {2,2,1 }
                                , {2,2,2 }
                                , {2,2,3 }
                                , {2,3,1 }
                                , {2,3,2 }
                                , {2,3,3 }
                                , {3,1,1 }
                                , {3,1,2 }
                                , {3,1,3 }
                                , {3,2,1 }
                                , {3,2,2 }
                                , {3,2,3 }
                                , {3,3,1 }
                                , {3,3,2 }
                                , {3,3,3} };

        public int[,] matrica2 = { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 3, 3 }, { 3, 2 }, { 3, 1 } };


        public int Numero(int[,] matrica, int n, int m)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {

                    if (matrica[i, j - 1] <= matrica[i, j] || matrica[i, j - 1] % matrica[i, j] != 0)
                    {
                        if (j == m - 1)
                        {
                            count++;

                        }
                    }
                    else
                    {
                        if (i == n - 1)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                            j = 0;
                        }
                    }
                }
            }
            return count;
        }

    }
}
