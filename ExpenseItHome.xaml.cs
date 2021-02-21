using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ExpenseIt
{
    /// <summary>
    /// Logika interakcji dla klasy ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        private DataBaseService _dbService;
        private ObservableCollection<PersonModel> _users = new ObservableCollection<PersonModel>();
        public ExpenseItHome()
        {
            _dbService = new DataBaseService();
            _users = new ObservableCollection<PersonModel>(_dbService.LoadUsers());
            InitializeComponent();
            peopleListBox.ItemsSource = _users;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
