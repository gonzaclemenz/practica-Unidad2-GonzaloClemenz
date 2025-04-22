using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Unidad2_GonzaloClemenz
{
    public enum EstadoChat
    {
        Abierto,
        EnProceso
    }
    public class Chat
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public EstadoChat Estado { get; set; }
        public List<Mensaje> Mensajes { get; set; } = new();
    }
}
