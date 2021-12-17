using System;

namespace ApiWeb.Models
{
    public class Anotacao
    {
        public string Texto { get; set; }
        public string Exercicio { get; set; }
        public TimeSpan Tempo { get; set; }
        public double Peso { get; set; }
    }
}
