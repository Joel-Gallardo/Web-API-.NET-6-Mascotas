
namespace MascotasWebAPI.Models.Repository
{
    public interface IMascotaRepository
    {
        Task<List<Mascota>> GetListMascotas();
        Task<Mascota> GetMascota(int id);
        Task Deletemascota(Mascota mascota);
        Task <Mascota> PostMascota(Mascota mascota);
        Task PutMascota(Mascota mascota);
    }
}
