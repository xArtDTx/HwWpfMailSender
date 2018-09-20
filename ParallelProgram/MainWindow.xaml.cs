using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParallelProgram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int[,] matrixA = new int[100, 100];
        int[,] matrixB = new int[100, 100];
        int[,] matrixResult = new int[100, 100];


        public MainWindow()
        {
            InitializeComponent();
        }

        private Task<int> MatrixSync()
        {
            int z = matrixResult[100, 100];
            int x = matrixA[100, 100];
            int y = matrixB[100, 100];
            return Task.Run(() =>
            {
                if (matrixA.GetLength(1) == matrixB.GetLength(0))
                {
                    matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
                    for (int i = 0; i < matrixResult.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixResult.GetLength(1); j++)
                        {
                            matrixResult[i, j] = 0;
                            for (int k = 0; k < matrixA.GetLength(1); k++)
                            {
                                matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
                            }
                        }
                    }
                }
                z = x * y;
                Thread.Sleep(500);
                return z;
            });
        }


        private async void multimatrix_Click(object sender, RoutedEventArgs e)
        {
            multimatrix.IsEnabled = false;
            
            DataGrid1.DataContext = matrixA[100, 100].ToString();
            #region Матрица А заполение рандомными числами

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = random.Next(10);
                }
            }

            #endregion

            DataGrid2.DataContext = matrixB[100, 100].ToString();
            #region Матрица B заполение рандомными числами

            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = random.Next(10);
                }
            }

            #endregion

            
            Task<int> start = MatrixSync();
            await Task.WhenAll(new[] {start});
            DataGrid3.DataContext = matrixResult[100, 100].ToString();

            multimatrix.IsEnabled = true;
        }
    }
}

