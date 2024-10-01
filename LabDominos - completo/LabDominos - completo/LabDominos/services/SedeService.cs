using LabDominos.entities;
using LabDominos.repositories;
using System.Collections.Generic;

namespace LabDominos.services
{
    internal class SedeService
    {
        private SedeRepository sedeRepository = new SedeRepository();

        public bool Registrar(Sede sede)
        {
            if (sedeRepository.Existe(sede.CodigoSede))
            {
                return false;
            }
            else
            {
                sedeRepository.Registrar(sede);
                return true;
            }
        }

        public List<Sede> ListarTodo()
        {
            return SedeRepository.ListarTodo();
        }
    }
}
