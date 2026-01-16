using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAdoNet.Models
{
    public class Hospital
    {
        public int Hospital_Cod { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Num_cama { get; set; }
    }
}
