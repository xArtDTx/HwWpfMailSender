using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
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

namespace EfHwApp
{
    
    public partial class MainWindow : Window
    {
        private readonly DataBaseContainer _financialAccounting = new DataBaseContainer();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _financialAccounting;
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _financialAccounting.FinancialAccountingSet.Load();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
           
            var financialAccounting = new FinancialAccounting
            {
                Profit = ProfitTxt.Text,
                Costs = CostsTxt.Text
            };

            _financialAccounting.FinancialAccountingSet.Add(financialAccounting);
            _financialAccounting.SaveChanges();
        }
    }
}
