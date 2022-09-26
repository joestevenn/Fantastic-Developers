using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota Mascota)
        {
            var MascotaAdicionado = _appContext.Mascotas.Add(Mascota);
            _appContext.SaveChanges();
            return MascotaAdicionado.Entity;
        }

        public void DeleteMascota(int idMascota)
        {
            var MascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (MascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(MascotaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Mascota> GetAllMascotas()
        {
            return GetAllMascotas_();
        }

        public IEnumerable<Mascota> GetMascotasPorFiltro(string filtro)
        {
            var Mascotas = GetAllMascotas(); // Obtiene todos los saludos
            if (Mascotas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    Mascotas = Mascotas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return Mascotas;
        }

        public IEnumerable<Mascota> GetAllMascotas_()
        {
            return _appContext.Mascotas;
        }

       public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Include("Historia").FirstOrDefault(d => d.Id == idMascota);
        }

        public Mascota UpdateMascota(Mascota Mascota)
        {
            var MascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == Mascota.Id);
            if (MascotaEncontrado != null)
            {
                MascotaEncontrado.Nombre = Mascota.Nombre;
                MascotaEncontrado.Color = Mascota.Color;
                MascotaEncontrado.Especie = Mascota.Especie;
                MascotaEncontrado.Raza = Mascota.Raza;                
                _appContext.SaveChanges();
            }
            return MascotaEncontrado;
        }

        public Veterinario AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
                if (veterinarioEncontrado != null)
                {
                    mascotaEncontrado.Veterinario = veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;
        }   

        public Dueno AsignarDueno(int idMascota, int idDueno)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var duenoEncontrado = _appContext.Duenos.FirstOrDefault(v => v.Id == idDueno);
                if (duenoEncontrado != null)
                {
                    mascotaEncontrado.Dueno = duenoEncontrado;
                    _appContext.SaveChanges();
                }
                return duenoEncontrado;
            }
            return null;
        }   

        public Historia AsignarHistoria(int idMascota, int idHistoria)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var historiaEncontrado = _appContext.Historias.FirstOrDefault(v => v.Id == idHistoria);
                if (historiaEncontrado != null)
                {
                    mascotaEncontrado.Historia = historiaEncontrado;
                    _appContext.SaveChanges();
                }
                return historiaEncontrado;
            }
            return null;
        }
    }
}