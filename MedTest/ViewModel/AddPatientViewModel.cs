using MedTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MedTest.ViewModel
{
    class AddPatientViewModel : DependencyObject
    {
        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));

        public string SecondName
        {
            get { return (string)GetValue(SecondNameProperty); }
            set { SetValue(SecondNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondNameProperty =
            DependencyProperty.Register("SecondName", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));



        public string Patronimyc
        {
            get { return (string)GetValue(PatronimycProperty); }
            set { SetValue(PatronimycProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Patronimyc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PatronimycProperty =
            DependencyProperty.Register("Patronimyc", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));



        public string Sex
        {
            get { return (string)GetValue(SexProperty); }
            set { SetValue(SexProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Sex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SexProperty =
            DependencyProperty.Register("Sex", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));



        public DateTime BirthDate
        {
            get { return (DateTime)GetValue(BirthDateProperty); }
            set { SetValue(BirthDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BirthDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BirthDateProperty =
            DependencyProperty.Register("BirthDate", typeof(DateTime), typeof(AddPatientViewModel), new PropertyMetadata(null));




        public string Address
        {
            get { return (string)GetValue(AddressProperty); }
            set { SetValue(AddressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Address.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddressProperty =
            DependencyProperty.Register("Address", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));



        public string PhoneNumber
        {
            get { return (string)GetValue(PhoneNumberProperty); }
            set { SetValue(PhoneNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PhoneNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register("PhoneNumber", typeof(string), typeof(AddPatientViewModel), new PropertyMetadata(""));


        public AddPatientViewModel()
        {
            
        }








    }
}
