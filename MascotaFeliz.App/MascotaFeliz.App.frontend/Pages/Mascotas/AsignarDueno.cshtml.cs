using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Pages
{
    public class AsignarDuenoModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;

        [BindProperty]
        public Mascota mascota {get;set;}
        public IEnumerable<Dueno> listaDuenos {get; set;}
        public IEnumerable<Veterinario> listaVeterinarios {get; set;}

        public AsignarDuenoModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }


        public IActionResult OnGet(int mascotaId)
        {
            mascota= _repoMascota.GetMascota(mascotaId);
            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            if (mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        /*public IActionResult OnPost(Mascota mascota, int duenoId)
        {
            if (ModelState.IsValid > 0)
            {
                dueno = _repoDueno.GetDueno(duenoId);
                if (mascota.Id > 0)
                {
                    mascota.Dueno = dueno;
                    _repoMascota.UpdateMascota(mascota);
                    _repoMascota.AsignarDueno(mascota.Id, duenoId);
                }
                return RedirectToPage("../Mascotas/ListaMascotas");                

            }            
            else
            {
                return Page();
            }
            
        }*/


    }
}
