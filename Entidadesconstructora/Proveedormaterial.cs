using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadesconstructora
{
    public class Proveedormaterial
    {
        public string Recibio { get; set; }
        public string Entrega { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_Entre { get; set; }
        public float Precio { get; set; }
        public int ID_Obra { get; set; }
        public int ID_Material { get; set; }
        
        public int ID_Proveedor { get; set; }
    }
}
