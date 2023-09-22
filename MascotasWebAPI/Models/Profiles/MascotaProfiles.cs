using AutoMapper;
using MascotasWebAPI.Models.DTO;

namespace MascotasWebAPI.Models.Profiles
{
    public class MascotaProfiles: Profile
    {
        public MascotaProfiles()
        {
            CreateMap<Mascota, MascotaDTO>();
            CreateMap<MascotaDTO, Mascota>();
        }
    }
}
