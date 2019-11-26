using MedTest.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataContext data;
        PatientRepository patientRepository;

        public MainWindow()
        {
            InitializeComponent();
            data = new DataContext();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            patientRepository = new PatientRepository(data);
            var viewModel = new PatientsViewModel(patientRepository);
            patientRepository.EventAddElement += viewModel.UpdateViewModel;
            DataContext = viewModel;
        }
        
        private void AddPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPatientPage patientPage = new AddPatientPage(patientRepository);
            patientPage.ShowDialog();
        }
    }
}
