using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTest.Model
{
    public class PatientRepository
    {
        private readonly DbSet<Patient> patients;

        public BindingList<Patient> GetPatients()
        {
            return patients.Local.ToBindingList();
        }

        public void AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void RemovePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void EditPatient(Patient patient, object property)
        {
            throw new NotImplementedException();
        }

        public PatientRepository(DataContext ctx)
        {
            patients = ctx.Patients;
            patients.Load();
        }
    }
}
