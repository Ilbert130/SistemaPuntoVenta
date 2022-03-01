using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Conexion
{
    internal class Conexion: DataConnection
    {
        public Conexion() : base("SistemaPOS")
        {

        }
    }
}
