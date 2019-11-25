using MedTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MedTest.ViewModel
{
    class PatientsViewModel : DependencyObject
    {
        PatientRepository PatientRepo;
               
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(PatientsViewModel), new PropertyMetadata(""));

        private bool FilterPatient(object obj)
        {
            bool result = true;
            Patient current = obj as Patient;
            if(current != null)
            {
                return result;
            }
            return result;
        }

        public ICollectionView Patients
        {
            get { return (ICollectionView)GetValue(PatientsProperty); }
            set { SetValue(PatientsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PatientsProperty =
            DependencyProperty.Register("Patients", typeof(ICollectionView), typeof(PatientsViewModel), new PropertyMetadata(null));

        public PatientsViewModel()
        {
            PatientRepo = new PatientRepository(new DataContext());
            Patients = CollectionViewSource.GetDefaultView(PatientRepo.GetPatients());
            
        }

    }
}
