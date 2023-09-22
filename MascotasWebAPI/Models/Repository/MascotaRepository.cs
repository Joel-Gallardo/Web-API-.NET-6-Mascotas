using AutoMapper;
using MascotasWebAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace MascotasWebAPI.Models.Repository
{
    public class MascotaRepository : IMascotaRepository
    {
        public readonly ApplicationDbContext _context;

        public MascotaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Mascota> PostMascota(Mascota mascota)
        {
            _context.Add(mascota);
            await _context.SaveChangesAsync();

            return mascota;
        }

        public async Task Deletemascota(Mascota mascota)
        {
            _context.Mascotas.Remove(mascota);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Mascota>> GetListMascotas()
        {
            return await _context.Mascotas.ToListAsync();

        }

        public async Task<Mascota> GetMascota(int id)
        {
            return await _context.Mascotas.FindAsync(id);
        }

        public async Task PutMascota(Mascota mascota)
        {
            var mascotaItem = await _context.Mascotas.FirstOrDefaultAsync(x => x.Id == mascota.Id);

            if (mascotaItem != null)
            {
                mascotaItem.Nombre = mascota.Nombre;
                mascotaItem.Raza = mascota.Raza;
                mascotaItem.Edad = mascota.Edad;
                mascotaItem.Peso = mascota.Peso;
                mascotaItem.Color = mascota.Color;

                await _context.SaveChangesAsync();
            }

        }
    }
}
