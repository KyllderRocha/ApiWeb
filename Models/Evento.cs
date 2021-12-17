using System;

namespace ApiWeb.Models
{
    public class Evento
    {
        public int ID { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string title { get; set; }
        public bool allDay { get; set; }
    }
}
