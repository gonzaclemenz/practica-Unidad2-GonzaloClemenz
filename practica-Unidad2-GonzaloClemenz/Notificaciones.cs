using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Unidad2_GonzaloClemenz
{
    public enum CategoriaNotificacion
    {
        SolicitudAmistad,
        NuevoChat,
        NoticiaPlataforma,
        NuevoJuego
    }
    public class Notificaciones
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioReceptorId { get; set; }
        public CategoriaNotificacion Categoria { get; set; }
        public bool Leida { get; set; }
    }
}
