using System;

namespace ApiWeb.Models
{
    public class Anotacao
    {
        public string Texto { get; set; }
        public string Exercicio { get; set; }
        public string Tempo { get; set; }
        public double Peso { get; set; }
        public DateTime Data { get; set; }
    }
}
