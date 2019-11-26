using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTest.Model
{
    public interface IRepository<T>
    {
        BindingList<T> GetElements();

        void AddElement(T element);

        event Action<object> EventAddElement;
    }
}
