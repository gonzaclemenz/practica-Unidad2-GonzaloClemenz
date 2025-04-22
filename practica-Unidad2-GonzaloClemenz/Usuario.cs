using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_Unidad2_GonzaloClemenz
{
    public enum CategoriaJuego
    {
       Accion, Rol, Aventura, Deportes, Estrategia, Simulacion
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Nickname { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public List<CategoriaJuego> CategoriasFavoritas { get; set; } = new();
        public List<int> Amigos { get; set; } = new();
    }
}
