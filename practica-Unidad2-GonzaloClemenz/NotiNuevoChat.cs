using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Unidad2_GonzaloClemenz
{
    public class NotiNuevoChat : Notificaciones
    {
        public int UsuarioIniciadorId { get; set; }
        public int ChatId { get; set; }
    }
}
