using MedTest.ViewModel;
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

namespace MedTest
{
    /// <summary>
    /// Логика взаимодействия для AddPatientPage.xaml
    /// </summary>
    public partial class AddPatientPage : Window
    {
        public AddPatientPage()
        {
            InitializeComponent();
            Loaded += AddPatientPage_Loaded;
        }

        private void AddPatientPage_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AddPatientViewModel();
        }
    }
}
