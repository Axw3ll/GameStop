using GameStop.Models;

namespace GameStop.Repositorio
{
    public interface IRepositorioJuegos
    {
        Task<List<Juego>> GetAll();
        Task<Juego?> Get(int id);
        Task<List<Clasificacion>> GetClasificaciones();
        Task<List<Personaje>> GetPersonajes();
        Task<Juego> Add(Juego juego);
        //Clasificaciones
        Task<Clasificacion> AddClasificacion(Clasificacion clasificacion);
        Task UpdateClasificacion(int id, Clasificacion clasificacion);

        Task Update(int id, Juego juego);
        Task Delete(int id);
    }
}
