using MedTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MedTest.ViewModel
{
    public class AddPatientViewModel : DependencyObject
    {
        //static List<string> BannedSimbols = new List<string>
        //{
        //    ".",
        //    ",",
        //    "/",
        //    "*",
        //    "+",
        //    "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
        //};

        public ICommand MyCommand { get; set; }   

        #region First Name
        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata("", FirstName_Changed));

        private static void FirstName_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = d as AddPatientViewModel;
            if (vm != null)
            {
                vm.FirstName = vm.FirstName.ToUpper();
            }
        }
        #endregion

        #region Second Name
        public string SecondName
        {
            get { return (string)GetValue(SecondNameProperty); }
            set { SetValue(SecondNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondNameProperty =
            DependencyProperty.Register("SecondName", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata("", SecondName_Changed));

        private static void SecondName_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = d as AddPatientViewModel;
            if (vm != null)
            {
                vm.SecondName = vm.SecondName.ToUpper();
            }
        }
        #endregion

        #region Patronimyc
        public string Patronimyc
        {
            get { return (string)GetValue(PatronimycProperty); }
            set { SetValue(PatronimycProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Patronimyc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PatronimycProperty =
            DependencyProperty.Register("Patronimyc", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata("", Patronimyc_Changed));

        private static void Patronimyc_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var vm = d as AddPatientViewModel;
            if (vm != null)
            {
                vm.Patronimyc = vm.Patronimyc.ToUpper();
            }
        }
        #endregion

        #region Sex
        public string Sex
        {
            get { return (string)GetValue(SexProperty); }
            set { SetValue(SexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Sex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SexProperty =
            DependencyProperty.Register("Sex", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata("МУЖСКОЙ"));
        #endregion

        #region Birth Date
        public DateTime? BirthDate
        {
            get { return (DateTime?)GetValue(BirthDateProperty); }
            set
            {
                if(BirthDate != value)
                {
                    SetValue(BirthDateProperty, value);
                }                
            }
        }

        // Using a DependencyProperty as the backing store for BirthDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BirthDateProperty =
            DependencyProperty.Register("BirthDate", typeof(DateTime?), typeof(AddPatientViewModel), new PropertyMetadata(DateTime.Now));
        #endregion

        #region Address
        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Address.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddressProperty =
            DependencyProperty.Register("Address", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));
        #endregion

        #region Phone number
        public string PhoneNumber
        {
            get { return (string)GetValue(PhoneNumberProperty); }
            set { SetValue(PhoneNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PhoneNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register("PhoneNumber", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));


        #endregion
        
    }
}
