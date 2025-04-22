using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Unidad2_GonzaloClemenz
{
    public class NotiSoliAmistad : Notificaciones
    {
        public DateTime FechaExpiracion { get; set; }
        public int UsuarioEmisorId { get; set; }
        public int ChatId { get; set; }
    }
}
