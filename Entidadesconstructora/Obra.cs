using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadesconstructora
{
     public class Obra
    {
        public int ID_Obra { get; set; }
        public string Nom_obra { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_Termino { get; set; }

        public int ID_Dueno { get; set; }

        public int Id_Encargado { get; set; }
    }
}
