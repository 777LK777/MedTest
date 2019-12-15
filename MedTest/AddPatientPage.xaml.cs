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
using System.Windows.Shapes;

namespace MedTest
{
    /// <summary>
    /// Логика взаимодействия для AddPatientPage.xaml
    /// </summary>
    public partial class AddPatientPage : Window
    {
        IRepository<Patient> patientsRepository;
        AddPatientViewModel MyVM;

        public AddPatientPage(IRepository<Patient> repository)
        {
            InitializeComponent();
            Loaded += AddPatientPage_Loaded;
            patientsRepository = repository;
        }

        private void AddPatientPage_Loaded(object sender, RoutedEventArgs e)
        {
            MyVM = new AddPatientViewModel();
            
            MyVM.MyCommand = new Command(x => { MessageBox.Show(MyVM.FirstName); }, y => { return true; });

            DataContext = MyVM;
            MyVM.MyCommand.Execute(null);

        }

        
    }
}
