using System;

namespace Di
{
    class Estudiante
    {
        public Estudiante(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = new Random().Next();
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }

    }
}
