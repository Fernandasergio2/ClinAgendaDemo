using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinAgenda.src.Application.DTOs.Specialty;
using ClinAgendaDemo.src.Application.DTOs.Doctor;
using ClinAgendaDemo.src.Application.DTOs.Patient;

namespace ClinAgendaDemo.src.Application.DTOs.Appointment
{
    public class AppointmentListReturnDTO
    {
         public int Id { get; set; }
        public required PatientReturnAppointmentDTO Patient { get; set; }
        public required DoctorReturnAppointmentDTO Doctor { get; set; }
        public required SpecialtyDTO Specialty { get; set; }
        public required string AppointmentDate { get; set; }
    }
}
