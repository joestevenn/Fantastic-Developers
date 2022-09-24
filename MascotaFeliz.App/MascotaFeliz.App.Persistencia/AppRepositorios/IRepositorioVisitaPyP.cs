using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        IEnumerable<VisitaPyP> GetAllVisitaPyPs();
        VisitaPyP AddVisitaPyP(VisitaPyP visitaVisitaPyP);
        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaVisitaPyP);
        void DeleteVisitaPyP(int idVisitaPyP);
        VisitaPyP GetVisitaPyP(int idVisitaPyP);
        //IEnumerable<VisitaPyP> GetVisitaPyPsPorFiltro(string filtro);
    }
}