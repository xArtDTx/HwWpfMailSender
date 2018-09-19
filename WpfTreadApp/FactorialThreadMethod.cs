using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;


namespace WpfTreadApp
{
    public static class FactorialThreadMethod
    {
        
        public static int FactorialSrch(int x)
        {
            Thread threadFactorial = new Thread(new ThreadStart(ThreadMethod));
            threadFactorial.Name = "Вторичный поток";
            threadFactorial.Start();
            //MessageBox.Show(threadFactorial.Name);
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * FactorialSrch(x - 1);
            }
        }

        public static void ThreadMethod()
        {
            Thread.Sleep(200);
            //MessageBox.Show($"{Thread.CurrentThread.Name} stoped.");
        }
    }
}