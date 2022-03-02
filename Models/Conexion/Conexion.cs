using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Conexion
{
    public class Conexion: DataConnection
    {
        public Conexion() : base("SistemaPOS")
        {

        }

        //Con esta propiedad obtenemos la tabla de la base de datos
        //Esto seria similar a un DbSet en entityframework
        public ITable<TClientes> TClientes { get { return GetTable<TClientes>(); } }
        public ITable<TReportes_clientes> TReportes_clientes { get { return GetTable<TReportes_clientes>(); } }
    }
}
