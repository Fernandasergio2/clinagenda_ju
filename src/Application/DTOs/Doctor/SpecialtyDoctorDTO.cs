using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clinagenda.src.Application.DTOs.specialties
{
    public class SpecialtyDoctorDTO
    {
        public int DoctorId { get; set; }
        public int SpecialtyId { get; set; }
        public required string SpecialtyName { get; set; }
        public int MyProperty { get; set; }
        public int ScheduleDuration { get; set; }

    }
}