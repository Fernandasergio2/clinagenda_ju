using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinagenda.src.Application.DTOs.Doctor;
using clinagenda.src.Application.DTOs.specialties;


namespace clinagenda.src.Core.Interfaces
{
     public interface IDoctorRepository
    {
        Task<IEnumerable<DoctorListDTO>> GetDoctorsAsync(string? name, int? specialtyId, int? statusId, int offset, int pageSize);
        Task<IEnumerable<SpecialtyDoctorDTO>> GetDoctorSpecialtiesAsync(int[] doctorIds);
        Task<int> InsertDoctorAsync(DoctorInsertDTO doctor);
        Task<IEnumerable<DoctorListDTO>> GetByIdAsync(int id);
        Task<bool> UpdateAsync(DoctorDTO doctor);
         Task<int> DeleteByDoctorIdAsync(int id);
    }
}