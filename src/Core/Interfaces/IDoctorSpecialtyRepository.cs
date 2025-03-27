using clinagenda.src.Application.DTOs.Doctor;

namespace clinagenda.src.Core.Interfaces
{
    public interface IDoctorSpecialtyRepository
   {
        Task InsertAsync(DoctorSpecialtyDTO doctor);
        Task DeleteByDoctorIdAsync(int doctorId);
    }
}