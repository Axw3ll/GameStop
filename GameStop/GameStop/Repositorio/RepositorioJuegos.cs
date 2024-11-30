﻿using GameStop.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStop.Repositorio
{
    public class RepositorioJuegos : IRepositorioJuegos
    {
        private readonly GameStopDBContext _context;

        public RepositorioJuegos(GameStopDBContext context)
        {
            _context = context;
        }

        public async Task<Juego> Add(Juego juego)
        {
            await _context.Juegos.AddAsync(juego);
            await _context.SaveChangesAsync();
            return juego;
        }
        //Add categorias
        public async Task<Clasificacion> AddClasificacion(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
            return clasificacion;
        }
        public async Task Delete(int id)
        {
            var persona = await _context.Juegos.FindAsync(id);
            if (persona != null)
            {
                _context.Juegos.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Juego?> Get(int id)
        {
            return await _context.Juegos.Include(p => p.Personajes).Where(r => r.id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Juego>> GetAll()
        {
            return await _context.Juegos.Include(c => c.Clasificacion).ToListAsync();
        }

        public async Task<List<Clasificacion>> GetClasificaciones()
        {
            return await _context.Clasificaciones.ToListAsync();
        }

        public async Task<List<Personaje>> GetPersonajes()
        {
            return await _context.Personajes.ToListAsync();
        }



        public async Task Update(int id, Juego juego)
        {
            var juegoactual = await _context.Juegos.FindAsync(id);
            if (juegoactual != null)
            {
                juegoactual.name = juego.name;
                juegoactual.description = juego.description;
                juegoactual.Personajes = juego.Personajes;
                await _context.SaveChangesAsync();
            }
        }

        //upadte categorias
        public async Task UpdateClasificacion(int id, Clasificacion clasificacion)
        {
            var clasificacionActual = await _context.Clasificaciones.FindAsync(id);
            if (clasificacionActual != null)
            {
                clasificacionActual.nombre = clasificacion.nombre;
                await _context.SaveChangesAsync();
            }
        }
    }
}