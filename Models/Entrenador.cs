using System.Collections.Generic;

namespace pokemonapp.Models
{
    public class Entrenador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public Pueblo Pueblo { get; set; }
    }
}