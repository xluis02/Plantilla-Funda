using LabDominos.entities;
using System;
using System.Collections.Generic;

namespace LabDominos.repositories
{
    internal class SedeRepository
    {
        private static List<Sede> sedes = new List<Sede>();

        public bool Existe(String codigoSede)
        {
            return sedes.Exists(s => s.CodigoSede.Equals(codigoSede));
        }

        public void Registrar(Sede sede)
        {
            sedes.Add(sede);
        }

        public static List<Sede> ListarTodo()
        {
            return sedes;
        }
    }
}
