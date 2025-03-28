using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinAgendaDemo.src.Application.DTOs.Appointment;

namespace ClinAgendaDemo.src.Core.Interfaces
{
    public interface IAppointmentRepository
 {
        Task<(int total, IEnumerable<AppointmentListDTO> appointment)> GetAppointmentsAsync(string? patientName, string? doctorName, int? specialtyId, int itemsPerPage, int page);
        Task<int> InsertAppointmentAsync(AppointmentDTO appointment);
        Task<AppointmentDTO?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(AppointmentInsertDTO appointment);
    }
}