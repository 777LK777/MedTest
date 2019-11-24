using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTest.Model
{
    public class Appointment
    {
        public long Id { get; set; }

        /// <summary>
        /// Пациент
        /// </summary>
        readonly private Patient patient;

        /// <summary>
        /// Тип посещения
        /// </summary>
        [Required]
        public AppointmentType Type { get; set; }

        /// <summary>
        /// Дата посещения
        /// </summary>
        [Required]
        public DateTime DateOfVisit { get; set; }

        /// <summary>
        /// Диагноз
        /// </summary>
        [Required]
        public string Diagnosis { get; set; }

        /// <summary>
        /// Создание посещения
        /// </summary>
        /// <param name="patient">Пациент</param>
        public Appointment(Patient patient)
        {
            this.patient = patient;
        }
    }
}
