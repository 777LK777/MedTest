using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTest.Model
{
    public class PatientRepository : IRepository<Patient>
    {
        private readonly DataContext data;

        public event Action<object> EventAddElement;

        public BindingList<Patient> GetElements()
        {
            return data.Patients.Local.ToBindingList();
        }

        public void AddElement(Patient patient)
        {
            data.Patients.Add(patient);
            data.SaveChanges();
            EventAddElement?.Invoke(this);
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
            data = ctx;
        }
    }
}
