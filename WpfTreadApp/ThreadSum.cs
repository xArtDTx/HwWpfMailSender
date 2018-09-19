using System;
using System.Threading;
using System.Windows;

namespace WpfTreadApp
{
    public static class ThreadSum
    {
        public static int SumSrch(int x)
        {
            Thread threadSum = new Thread(new ThreadStart(ThreadMethod));
            threadSum.Name = "Secondary thread";
            threadSum.Start();
            //MessageBox.Show(threadSum.Name);

            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x + SumSrch(x - 1);
            }
        }

        public static void ThreadMethod()
        {
            Thread.Sleep(200);
            //MessageBox.Show($"{Thread.CurrentThread.Name} stoped.");
        }
    }
}