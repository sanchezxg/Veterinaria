using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entidades
{
    public class medico
    {
        public int Id { get; set; } //Campo obligatorio, es la clave primaria por defecto

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public int Codigo { get; set; }


    }
}
