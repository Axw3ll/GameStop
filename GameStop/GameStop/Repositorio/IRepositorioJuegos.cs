using GameStop.Models;

namespace GameStop.Repositorio
{
    public interface IRepositorioJuegos
    {
        Task<List<Juego>> GetAll();
        Task<Juego?> Get(int id);
        Task<List<Clasificacion>> GetClasificaciones();
        Task<List<Personaje>> GetPersonajes();
        Task Update(int id, Juego juego);
        Task Delete(int id);

        Task<Juego> Add(Juego juego);
        //Agregar Clasificaciones
        Task<Clasificacion> AddClasificacion(Clasificacion clasificacion);
        //Editar Clasificacion
        Task UpdateClasificacion(int id, Clasificacion clasificacion);
        //Eliminar Clasificacion
        Task DeleteClasificacion(int id);

        //Add personajes
        Task<Personaje> AddPersonaje(Personaje personaje);
        //Eliminar Peronsaje
        Task DeletePersonaje(int id);

        //Editar Personaje
        Task UpdatePersonaje(int id, Personaje personaje);

    }
}
