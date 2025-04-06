using SqlConnectionDialog.ViewModel;
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
using System.Windows.Shapes;

namespace SqlConnectionDialog.Views
{
    /// <summary>
    /// Логика взаимодействия для NameDbWindow.xaml
    /// </summary>
    public partial class NameDbWindow : Window
    {
        public string DBName = string.Empty;
        public NameDbWindow(string _dbName)
        {
            InitializeComponent();
            DBName = _dbName;
            ((NameDbAddedVM)this.DataContext).NameDB = _dbName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBName = ((NameDbAddedVM)this.DataContext).NameDB;
            this.DialogResult = true;
        }
    }
}
