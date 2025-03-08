using SqlConnectionDialog.Utils;
using SqlConnectionDialog.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SqlConnectionDialog.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();

        public MainWindow(System.Data.SqlClient.SqlConnectionStringBuilder? _sqlConnectionStringBuilder)
        {
            if (_sqlConnectionStringBuilder!=null) this.sqlConnectionStringBuilder = _sqlConnectionStringBuilder;
            InitializeComponent();
            ((MainWindowVM)this.DataContext).sqlConnectionStringBuilder = this.sqlConnectionStringBuilder;
        }

        private void ok_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.DialogResult = true;
            }
            catch { }
        }

        private void cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.DialogResult = false;
            }
            catch { }
            this.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = TextBoxValidator.IntegerNumberValidationTextBox(sender, e);
        }
        private void DoubleNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = TextBoxValidator.DoubleNumberValidationTextBox(sender, e);
        }
    }
}