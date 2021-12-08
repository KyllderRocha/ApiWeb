using System;

namespace ApiWeb.Models
{
    public class Evento
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
    }
}
